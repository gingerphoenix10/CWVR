using HarmonyLib;
using UnityEngine.EventSystems;

namespace CWVR.Patches;

[CWVRPatch]
[HarmonyPatch]
internal static class CurvedUIPatches
{
    /// <summary>
    /// Disable curved UI input module since it messes with VR inputs
    /// </summary>
    [HarmonyPatch(typeof(StandaloneInputModule), "UpdateModule")]
    [HarmonyPostfix]
    private static void OnCurvedUIInputModuleStart(CurvedUIInputModule __instance)
    {
        __instance.enabled = false;
    }
}
