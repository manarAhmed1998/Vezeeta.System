using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;
using System.Security.Claims;
using System.Text;
using Vezeeta.System.BL;
using Vezeeta.System.BL.Managers.Admin;
using Vezeeta.System.BL.Managers.LoginService;
using Vezeeta.System.DAL;
using Vezeeta.System.DAL.Repos.Appointments;
using Vezeeta.System.DAL.Repos.Times;

var builder = WebApplication.CreateBuilder(args);

#region Services & context

//configure context service in the Dependency injection container
var connectionString = builder.Configuration.GetConnectionString("Vezeeta_Connection_String");
builder.Services.AddDbContext<VezeetaContext>(options =>  
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IDoctorsRepo, DoctorsRepo>();
builder.Services.AddScoped<IPatientsRepo, PatientsRepo>();
builder.Services.AddScoped<IAdminManager, AdminManager>();
builder.Services.AddScoped<IDoctorsManager, DoctorsManager>();
builder.Services.AddScoped<IPatientsManager, PatientsManager>();
builder.Services.AddScoped<IAppointmentsRepo, AppointmentsRepo>();
builder.Services.AddScoped<ITimesRepo, TimesRepo>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion region

#region ASP identity

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;

    options.User.RequireUniqueEmail = true;
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
}).AddEntityFrameworkStores<VezeetaContext>();
#endregion

#region authentiacation
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "default";
    options.DefaultChallengeScheme = "default";
    }).
    AddJwtBearer("default", options =>
    {
        var secretKey = builder.Configuration.GetValue<string>("SecretKey");
        var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
        var key = new SymmetricSecurityKey(secretKeyInBytes);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            //authentication provider
            ValidateIssuer = false,
            //secured application
            ValidateAudience = false,
            IssuerSigningKey = key
        };
    });

#endregion

#region Authorization
//admin,doctor,patient
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Doctor", policy =>
    policy.RequireClaim(ClaimTypes.Role, "Doctor"));
    options.AddPolicy("Admin", policy =>
    policy.RequireClaim(ClaimTypes.Role, "Admin"));
    options.AddPolicy("Patient", policy =>
    policy.RequireClaim(ClaimTypes.Role, "Patient"));
});
#endregion 

#region default services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

var app = builder.Build();

#region middlewares

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//setting up the path for our default static files folder
var staticFilesPath = Path.Combine(Environment.CurrentDirectory, "Images");
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider=new PhysicalFileProvider(staticFilesPath),
    //it can be named anything
    RequestPath="/Images"
});

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
#endregion

app.Run();
