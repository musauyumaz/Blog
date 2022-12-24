using Microsoft.Extensions.Configuration;

namespace Blog.Persistence.Configurations
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Blog.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("BlogDB");
            }
        }
    }
}
