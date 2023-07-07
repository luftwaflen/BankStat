using System.Text;
using BankStatAlphaBankIntegration.Services.Implementations;
using BankStatAlphaBankIntegration.Services.Interfaces;
using BankStatApi.Profiles;
using BankStatApplication.Services;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatInfrastructure.EF;
using BankStatInfrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace BankStatApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connection = builder.Configuration
                .GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<BankContext>(options =>
                options
                    .UseLazyLoadingProxies()
                    .UseSqlite(connection)
            );

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IOperationRepository, OperationRepository>();
            builder.Services.AddScoped<ICurrencyRepository, CurrencyRepository>();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IOperationService, OperationService>();

            builder.Services.AddScoped<IAlphaAccountService, AlphaAccountService>();

            builder.Services.AddAutoMapper(
                typeof(UserModelToRes),
                typeof(AccountModelToRes),
                typeof(OperationModelToRes)
            );

            builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = "ISSUER",
                        ValidateAudience = true,
                        ValidAudience = "AUDIENCE",
                        ValidateLifetime = false,
                        ValidateIssuerSigningKey = true,
                        
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes("!SomethingSecret!")
                        )
                    };
                });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Bank stat", Version = "v1" });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });

            var app = builder.Build();

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

            app.Run();
        }
    }
}