## About

This package contains a diverse collection of helpful scripts (MonoBehaviours, Math, Logic & Management Helpers, Extensions, etc.) for the Unity3D runtime environment and the Editor as well!

Checkout the [Features](#features) section below for more information about the specific use cases and available helper scripts.

## Support

Since I am developing and maintaining this asset package in my spare time, feel free to support me [via paypal](https://paypal.me/NikosProjects), [buy me a coffee](https://ko-fi.com/nikocreatestech) or check out my [games](https://store.steampowered.com/curator/44541812) or other [published assets](https://assetstore.unity.com/publishers/52812).

## Documentation

See the API doc [here](https://niggo1243.github.io/Unity3DHelperTools/annotated.html)

## Setup

### Unity Package Dependency

To add this toolkit as a package dependency to your Unity project, locate your manifest file in "Package/manifest.json" or add the git-url via the package manager UI.

In the previous versions of this package you had to add the NaughtyAttributes package dependency to the "scopedRegistries". Unfortunately this forced you to use a specific fork or version, so to avoid that restriction you have to add the NaughtyAttributes git url (fork/ version) of your liking yourself.

The current dependency is a fork with performance improvements ([https://github.com/niggo1243/NaughtyAttributes](https://github.com/niggo1243/NaughtyAttributes)) of the original open-source project NaughtyAttributes by dbrizov: [https://github.com/dbrizov/NaughtyAttributes](https://github.com/dbrizov/NaughtyAttributes)

The original NaughtyAttributes package works as well though and if you already have it installed, you don't have to add the forked branch in the following steps!

Add the following line to the "dependencies" section to include this package:
```
"com.nikosassets.helpers": "https://github.com/niggo1243/Unity3DHelperTools.git#upm"
```

For my NaughtyAttributes performance improvements fork:
```
"com.nikosassets.naughtyattributes": "https://github.com/niggo1243/NaughtyAttributes.git#upm"
```

The original branch:
```
"com.dbrizov.naughtyattributes": "https://github.com/dbrizov/NaughtyAttributes.git#upm"
```

You can also choose specific releases and tags after the "#" instead of "upm".

### Unity Project

You can simply download a (release) zip file or just clone this project via git.

## Features

You can find example Scenes under "Assets/NikosAssets/U3DHelperTools/Samples/Scenes"

### MonoBehaviours

*   Keep the Scene view in focus after pressing the play button:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/KeepSceneViewInFocus.PNG)

*   Look at a target with special settings and constraints:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/LookAt_Example.gif)

*   Alarm clock event emitter:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/AlarmClock.PNG)

*   A generic list/ destination container helper class, emitting events when the list changes:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/DestinationContainer.PNG)

*   An async Scene loader helper class, also emitting events:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/AsyncSceneLoader.PNG)

### Non-MonoBehaviours but here wrapped in sample MonoBehaviour classes

*   EditorUtilitiesHelper, copy or regenerate GUIDs, rename files or generate scripts and open a project only file picker:

![Image](https://raw.githubusercontent.com/niggo1243/Unity3DHelperTools/c09dec59d4029cba63a88cc1a452d66d726efe0d/Assets/NikosAssets/U3DHelperTools/Documentation/EditorUtilities_Example.PNG)

Also available via the toolbar:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/Editor_Toolbar_Helpers.PNG)

*   GUIHelper, to draw lines and boxes, in addition to the AlternatingListStyleHelper class:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/GUIHelper_Example.PNG)

Following picture from the [AiMalgam](https://assetstore.unity.com/packages/tools/ai/aimalgam-218556) asset (Control Panel):

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/GUIHelper_AiMalgam_ColorBoxAndList.PNG)

*   Various extension classes for object cloning, strings, NavmeshAgents, and Coroutines:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/Extensions_Example.PNG)

*   Help with Vector, Rigidbody and Quaternion calculations (and other math stuff):

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/NumericHelper_Example.PNG)

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RolyPoly_Example.gif)

*   Help with targeting transforms by distance:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/TargetingHelper_Example.PNG)

*   Generating random points in the 3D environment:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RandomPointsHelper_Example.PNG)

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RandomPoints_Example.gif)

*   Mapping strings to hashes:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/StringHasher_Example.PNG)

*   Offering some helpful methods for collections generally:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/CollectionHelper_Example.PNG)

*   Handy methods to retrieve type informations via reflection calls:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/ReflectionHelper_Example.PNG)