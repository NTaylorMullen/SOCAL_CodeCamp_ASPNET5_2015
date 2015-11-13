using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace AspNet5DemoRaw
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
            app.UseStaticFiles();

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