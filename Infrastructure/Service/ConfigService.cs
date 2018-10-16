using System.Configuration;

namespace Infrastructure
{
    public class ConfigService : IConfigService
    {
        public string MyConnection
        {
            get
            {
                string cnString = null;
                var cnSettings = ConfigurationManager.ConnectionStrings["PraiseDbContext"];
                if (cnSettings != null)
                {
                    cnString = cnSettings.ConnectionString;
                }
                return cnString;
            }
        }
    }
}