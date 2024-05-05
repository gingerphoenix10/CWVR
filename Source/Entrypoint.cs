using System.Collections;
using CWVR.Patches;
using CWVR.Player;
using CWVR.UI;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

namespace CWVR;

[CWVRPatch]
[HarmonyPatch]
internal static class VREntrypoint
{
    [HarmonyPatch(typeof(GameAPI), nameof(GameAPI.Awake))]
    [HarmonyPostfix]
    private static void OnGameEntered(GameAPI __instance)
    {
        if (__instance.name != "MainMenuGame")
            return;
        
        __instance.gameObject.AddComponent<MainMenu>();
    }
}

[CWVRPatch(CWVRPatchTarget.Universal)]
[HarmonyPatch]
internal static class UniversalEntrypoint
{
    [HarmonyPatch(typeof(GameAPI), nameof(GameAPI.Awake))]
    [HarmonyPostfix]
    private static void OnGameEntered(GameAPI __instance)
    {
        if (__instance.name == "MainMenuGame")
        {
            // Create settings menu
            Object.FindObjectOfType<MainMenuSettingsPage>(true).gameObject.AddComponent<UI.Settings.SettingsMenu>();
            return;
        }
        
        __instance.StartCoroutine(Start());
    }

    private static IEnumerator Start()
    {
        yield return new WaitUntil(() => global::Player.localPlayer is not null);

        if (SceneManager.GetActiveScene().name == "MainMenuGame")
            yield break;
        
        // Setup session manager
        new GameObject("CWVR Session Manager").AddComponent<VRSession>();
    }
}