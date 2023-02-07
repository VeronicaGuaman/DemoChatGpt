using Microsoft.Extensions.Hosting;

namespace HelloWorld
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Configure(app =>
                    {
                        app.Run(async context =>
                        {
                            await context.Response.WriteAsync("Hello, World!");
                        });
                    });
                })
                .Build();

            await host.RunAsync();
        }
    }
}
