using Microsoft.AspNetCore.Builder;


namespace R5T.W0001
{
    public class Program
    {
        public static void Main()
        {
            F0065.Instances.WebApplication
                .ConfigureServices(services =>
                {
                    services.UseServicesConfigurer_Synchronous<ServicesConfigurer>();
                })
                .ConfigureServices(services =>
                {

                })
                .ConfigureWebApplicationBuilder(webApplicationBuilder =>
                {
                    webApplicationBuilder.UseWebApplicationBuilderConfigurer_Synchronous<WebApplicationBuilderConfigurer>();
                })
                .Build()
                .ConfigureWebApplication(webApplication =>
                {
                    webApplication.MapGet("/", () => "Hello World!");
                })
                .ConfigureWebApplication(webApplication =>
                {
                    webApplication.UseWebApplicationConfigurer_Synchronous<WebApplicationConfigurer>();
                })
                .Run();
        }
    }
}