using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;

namespace ToggleLowPass.HarmonyPatches
{
    class LowPassPatch
    {
        [HarmonyPatch(typeof(HeadObstacleLowPassAudioEffect))]
        [HarmonyPatch("Update")]
        class LowPassEffectPatch
        {
            static bool Prefix(ref HeadObstacleLowPassAudioEffect ____headWasInObstacle, MainAudioEffects ____mainAudioEffects, PlayerHeadAndObstacleInteraction ____playerHeadAndObstacleInteraction)
            {
                if (PluginConfig.lowPass == false)
                {
                    bool flag = ____playerHeadAndObstacleInteraction.intersectingObstacles.Count > 0;
                    if (flag == ____headWasInObstacle)
                    {
                        return true;
                    }
                    if (flag)
                    {
                        //____mainAudioEffects.TriggerLowPass();
                    }
                    else
                    {
                        ____mainAudioEffects.ResumeNormalSound();
                    }
                    flag = ____headWasInObstacle;
                    return false;
                }
                else
                    return true;
            }

        }
    }
}
