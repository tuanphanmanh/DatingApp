using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IdentityServiceCollection services, 
        IConfiguration config )
        {
            object value = services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmertricSecurityKey(Encoding.UTF8.GetBytes(_config("TokenKey"))),
                        ValidateIsseuer = false,
                        ValidateAudience = false,
                    };
                });

            return services;
        }
    }
}