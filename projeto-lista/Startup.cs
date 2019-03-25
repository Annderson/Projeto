using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using projeto_lista.Entities;
using projeto_lista.Services;

namespace projeto_lista
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NomeContext>(opt => opt.UseInMemoryDatabase("NomeList"));
            services.AddScoped<LancheService>();
            services.AddScoped<UsuarioService>();

            // especifica o esquema usado para autenticacao do tipo Bearer
            // e 
            // define configurações como chave,algoritmo,validade, data expiracao...
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "anderson.rl.tr@gmail.com",
                    ValidAudience = "anderson.rl.tr@gmail.com",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]))
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context => {
                        Console.WriteLine("Token inválido..:. " + context.Exception.Message);
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context => {
                        Console.WriteLine("Toekn válido...: " + context.SecurityToken);
                        return Task.CompletedTask;
                    }
                };
            });

            services.AddCors (options => {
                options.AddPolicy ("CorsPolicy",
                    builder => {
                        builder
                            .AllowAnyMethod ()
                            .AllowAnyHeader ()
                            .AllowAnyOrigin ()
                            .AllowCredentials ();
                    });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            // Ative o middleware para servir o Swagger gerado como um terminal JSON.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // Habilitar o middleware para servir swagger-ui (HTML, JS, CSS, etc.)
            // specifying the Swagger JSON endpoint.
            // especificando o terminal JSON do Swagger.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors ("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
