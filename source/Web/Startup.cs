using DotNetCore.AspNetCore;
using DotNetCore.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            application.UseException();
            application.UseRouting();
            application.UseCorsAllowAny();
            application.UseHttps();
            application.UseAuthentication();
            application.UseAuthorization();
            application.UseResponseCompression();
            application.UseResponseCaching();
            application.UseStaticFiles();
            application.UseEndpoints(endpoints => endpoints.MapControllers());
            application.UseSpa();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLog();
            services.AddCors();
            services.AddSecurity();
            services.AddResponseCompression();
            services.AddResponseCaching();
            services.AddControllers();
            services.AddMvcJson();
            services.AddSpa();
            services.AddFileService();
            services.AddContext();
            services.AddClassesMatchingInterfaces();
        }
    }
}
