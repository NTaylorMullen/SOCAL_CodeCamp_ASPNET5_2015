using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace AspNet5DemoRaw
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
			app.Run(async context =>
			{
				await context.Response.WriteAsync("Hello World - RAW");
			});
		}
	}
}