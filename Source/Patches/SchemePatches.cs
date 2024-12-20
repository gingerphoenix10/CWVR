using CWVR.Player;
using HarmonyLib;
using UnityEngine.SceneManagement;
using Zorro.ControllerSupport;
using static UnityEngine.GraphicsBuffer;

namespace CWVR.Patches;

[CWVRPatch]
[HarmonyPatch]
internal static class SchemePatches
{
    [HarmonyPatch(typeof(ShowOnlyForScheme), "UpdateVisibility")]
    [HarmonyPrefix]
    private static bool UpdateVisibility(ShowOnlyForScheme __instance)
    {
        __instance.target.SetActive(__instance.scheme == InputScheme.KeyboardMouse);
        return false;
    }
}