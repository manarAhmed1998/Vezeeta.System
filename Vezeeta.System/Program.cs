using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Vezeeta.System.BL;
using Vezeeta.System.BL.Managers.Admin;
using Vezeeta.System.BL.Managers.LoginService;
using Vezeeta.System.DAL;
using Vezeeta.System.DAL.Repos.Appointments;
using Vezeeta.System.DAL.Repos.Times;

var builder = WebApplication.CreateBuilder(args);

#region Services

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


//adding identity

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


//authentiacation service
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

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
#endregion

app.Run();
