using System.Configuration;

namespace Services
{
    public class FeatureToggle
    {
        public bool IsEnabled(string name)
        {
            // default to enabled if setting not found or not boolean
            var settingValue = true;

            if (bool.TryParse(ConfigurationManager.AppSettings[name], out settingValue))
            {
                return settingValue;
            }
            return settingValue;
        }
    }
}
