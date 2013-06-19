using System.Configuration;

namespace SharpDesk.Infrastructure
{
    public class RepositoryBase
    {
        public string ApiKey
        {
            get
            {
                if(ConfigurationManager.AppSettings["ApiKey"] == null)
                    throw new ConfigurationErrorsException("Missing 'ApiKey' Configuration Value");

                return ConfigurationManager.AppSettings["ApiKey"];
            }
        }

        public string Domain
        {
            get
            {
                if (ConfigurationManager.AppSettings["Domain"] == null)
                    throw new ConfigurationErrorsException("Missing 'Domain' Configuration Value");

                return ConfigurationManager.AppSettings["Domain"];
            }
        }

    }
}
