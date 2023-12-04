using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Vezeeta.System.DAL;

var builder = WebApplication.CreateBuilder(args);

#region Services

var connectionString = builder.Configuration.GetConnectionString("Vezeeta_Connection_String");
builder.Services.AddDbContext<VezeetaContext>(options =>
    options.UseSqlServer(connectionString).EnableSensitiveDataLogging());

//authentiacation service
builder.Services.AddAuthentication("default").
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
