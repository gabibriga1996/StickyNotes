using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace StickyNotesAPIG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // הוספת תמיכה ב-Authentication עם JWT
            /*builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    var key = builder.Configuration["Jwt:Key"];
                    
                    if (string.IsNullOrEmpty(key))
                    {
                        throw new InvalidOperationException("JWT Key is missing in configuration.");
                    }

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)) // לוודא שהמפתח לא null
                    };
                });
*/
            // קריאה ל-API Key מתוך הקובץ
           /* string? openAiApiKey = builder.Configuration["ApiKeys:OpenAI"];
            if (string.IsNullOrEmpty(openAiApiKey))
            {
                throw new Exception("Missing OpenAI API Key in configuration.");
            }
*/
            // הוספת OpenAIService כ-Singleton
           // builder.Services.AddSingleton(new OpenAIService(openAiApiKey));

            // הוספת Controllers (בקרי API)
            builder.Services.AddControllers();

            // הוספת Swagger לתיעוד ה-API
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // הוספת CORS (לגישה מה-Frontend)
            /*builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });*/

            var app = builder.Build();

            // הפעלת Swagger בסביבת פיתוח
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // הפעלת CORS
           // app.UseCors("AllowAll");

            // הפעלת אימות והרשאות
            // app.UseAuthentication();
            // app.UseAuthorization();

            // הפעלת Controllers (בקרי ה-API)
            app.MapControllers();

            // הפעלת היישום
            app.Run();
        }
    }
}