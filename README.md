# Content Warning VR Mod

[![Thunderstore Version](https://img.shields.io/thunderstore/v/gingerphoenix10/CWVR?style=for-the-badge&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/content-warning/p/gingerphoenix10/CWVR)
[![GitHub Version](https://img.shields.io/github/v/release/gingerphoenix10/CWVR?style=for-the-badge&logo=github)](https://github.com/gingerphoenix10/CWVR/releases/latest)
[![Thunderstore Downloads](https://img.shields.io/thunderstore/dt/gingerphoenix10/CWVR?style=for-the-badge&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/content-warning/p/gingerphoenix10/CWVR)
[![GitHub Downloads](https://img.shields.io/github/downloads/gingerphoenix10/CWVR/total?style=for-the-badge&logo=github)](https://github.com/gingerphoenix10/CWVR/releases/latest)
<br>
#### Original Mod
[![Thunderstore Version](https://img.shields.io/thunderstore/v/DaXcess/CWVR?style=for-the-badge&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/content-warning/p/DaXcess/CWVR)
[![GitHub Version](https://img.shields.io/github/v/release/DaXcess/CWVR?style=for-the-badge&logo=github)](https://github.com/DaXcess/CWVR/releases/latest)
[![Thunderstore Downloads](https://img.shields.io/thunderstore/dt/DaXcess/CWVR?style=for-the-badge&logo=thunderstore&logoColor=white)](https://thunderstore.io/c/content-warning/p/DaXcess/CWVR)
[![GitHub Downloads](https://img.shields.io/github/downloads/DaXcess/CWVR/total?style=for-the-badge&logo=github)](https://github.com/DaXcess/CWVR/releases/latest)


CW // VR is a [BepInEx](https://docs.bepinex.dev/) mod developed by [DaXcess](https://github.com/DaXcess) that adds fully fledged, 6DOF VR support into Content Warning, including fully motion controlled hands.

This mod, just like his Lethal Company VR mod, is powered by Unity's OpenXR plugin, and is thereby compatible with a wide range of headsets and runtimes, like Oculus, Virtual Desktop, SteamVR and many more!

### Discord Server

We have a dedicated section within the [Flat2VR Discord Server](https://discord.com/invite/ZFSCSDe)!

Look for the [`#cw-join`](https://discord.com/channels/747967102895390741/1236717861653712896) channel to join the Content Warning VR section.

# What is this fork?

The original [CWVR](https://github.com/DaXcess/CWVR) mod was archived by DaXcess on 11th August 2024, meaning no more updates are being made to the project.

This means that updates to Content Warning itself can very easily break the mod, and with no mod updates, would never be able to work again without downgrading.

However, this fork is continuation of the project, allowing VR support on newer versions of Content Warning. This project is also planned to be uploaded to the official [Content Warning Workshop](https://steamcommunity.com/app/2881650/workshop/) eventually, if permission from DaXcess is given.

> [!WARNING]
> This project is still in beta, and may not work 100% as intended. However, everything has worked perfectly for me so far, so it's ready for release :)

# Install from source

To install the mod from the source code, you will first have to compile the mod. Instructions for this are available in [COMPILING.md](COMPILING.md).

Next up you'll need to grab a copy of some **Runtime Dependencies**. You can either grab these from [one of the releases](https://github.com/DaXcess/CWVR/releases), or if you truly want the no hand holding experience, you can retrieve them from a Unity project.

## Retrieving Runtime Dependencies from a Unity Project

First of all start by installing Unity 2022.3.10f1, which is the Unity version that Content Warning uses. Once you have installed the editor, create a new Unity project. If you are planning on adding prefabs to the mod, use the URP template and add the OpenXR plugin via the Unity package manager. Otherwise you can just use the VR template.

Make sure you set the scripting backend to Mono, and not to Il2Cpp (Unity will warn you when you try to compile a VR game with Il2Cpp enabled). You can now build your dummy game. Once the game is built you can navigate to it's `<Project Name>_Data/Managed` directory. There you will need to extract the following files:

- UnityEngine.SpatialTracking.dll
- Unity.XR.CoreUtils.dll
- Unity.XR.Interaction.Toolkit.dll
- Unity.XR.Management.dll
- Unity.XR.OpenXR.dll
- Unity.InputSystem.dll

And from the `<Project Name>_Data/Plugins/x86_64` directory:

- openxr_loader.dll
- UnityOpenXR.dll

## Install BepInEx

BepInEx is the modloader that CW // VR uses to mod the game. You can download BepInEx from their [GitHub Releases](https://github.com/BepInEx/BepInEx/releases) (CWVR currently targets BepInEx 5.4.22).

To install BepInEx, you can follow their [Installation Gude](https://docs.bepinex.dev/articles/user_guide/installation/index.html#installing-bepinex-1).

## Installing the mod

Once BepInEx has been installed and run at least once, you can start installing the mod.

First of all, in the `BepInEx/plugins` folder, create a new folder called `CWVR` (doesn't have to be named that specifically, but makes identification easier). Inside this folder, place the `CWVR.dll` file that was generated during the [COMPILING.md](COMPILING.md) steps.

After this has been completed, create a new directory called `RuntimeDeps` (has to be named exactly that) inside of the `CWVR` folder. Inside this folder you will need to put the DLLs that you have retrieved during the [Retrieving Runtime Depenencies](#retrieving-runtime-dependencies-from-a-unity-project) step. You can now run the game with CWVR installed.
