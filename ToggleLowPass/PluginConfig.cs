using BS_Utils.Utilities;

namespace ToggleLowPass
{
    internal class PluginConfig
    {
        public bool RegenerateConfig = true;
        private static Config config = new Config("modprefs");
        public static bool lowPass
        {
            get
            {
                return config.GetBool("ToggleLowPass", "Enable Low Pass", true, true);
            }
            set
            {
                config.SetBool("ToggleLowPass", "Enable Low Pass", value);
            }
        }
    }
}
