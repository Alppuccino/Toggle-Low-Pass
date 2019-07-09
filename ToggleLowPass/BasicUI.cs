using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomUI.GameplaySettings;

namespace ToggleLowPass
{
    class BasicUI
    {
        public static void CreateGameplayOptionsUI()
        {
            var pluginSubmenu = GameplaySettingsUI.CreateSubmenuOption(GameplaySettingsPanels.ModifiersLeft, "Toggle Low Pass", "MainMenu", "lowPass");

            var enabled = GameplaySettingsUI.CreateToggleOption(GameplaySettingsPanels.ModifiersLeft, "Enabled", "lowPass", "Toggles low pass audio filter when in obstacles");
            enabled.GetValue = PluginConfig.lowPass;
            enabled.OnToggle += (value) => { PluginConfig.lowPass = value; };
        }
    }
}
