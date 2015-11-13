using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace AspNet5DemoRaw
{
	public class Startup
	{
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
		{
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            app.Map("/otherpath", subApp =>
            {
                subApp.Run(async context =>
                {
                    await context.Response.WriteAsync("Other path");
                });
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World -- RAW");
            });
        }
	}
}