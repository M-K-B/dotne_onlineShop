using DotNetEnv;
namespace onlineShop.Models;

public class AppConfig
{
    
    //Env.load();
    
    public static string url = Environment.GetEnvironmentVariable("URL");
    public static string key = Environment.GetEnvironmentVariable("KEY");

    
    
    
}