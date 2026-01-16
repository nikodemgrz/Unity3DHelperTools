## About

This open-source package contains a collection of handy scripts like math algorithms (E.g. Vector & Quaternion helpers) for the Unity3D runtime environment and the Editor as well.

Checkout the [Features](#features) section below for more information about the specific use cases and available helper scripts.

## Support

Since I am developing and maintaining this asset package in my spare time, feel free to support me <a href="https://paypal.me/NikosProjects">via paypal</a>, <a href="https://www.buymeacoffee.com/nikosprojects">buy me a coffee</a> or check out my other <a href="https://assetstore.unity.com/publishers/52812">published assets</a>.

## Documentation

See the API doc <a href="https://api.niko-creates.tech/helpers/annotated.html">here</a>

## Setup

### Unity Package Dependency 

First you need to install the package dependency. For maintenance reasons I am no longer supporting scoped registries, so you will need to add the dependency manually as follows.<br>
The current dependency is a fork with performance improvements (https://github.com/nikodemgrz/NaughtyAttributes) of the original open-source project NaughtyAttributes by dbrizov:
https://github.com/dbrizov/NaughtyAttributes

In the Unity PackageManager either add:<br>
```https://github.com/nikodemgrz/NaughtyAttributes.git#upm```<br>
or:<br>
```https://github.com/dbrizov/NaughtyAttributes.git#upm```

You can also choose specific releases and tags after the "#" instead of "upm".

Now for this package, add the following git url in the Unity PackageManager:<br>
```https://github.com/nikodemgrz/Unity3DHelperTools.git#upm```

### Unity Project

You can simply download a (release) zip file or just clone this project via the git command: 

```
git clone --recursive https://github.com/nikodemgrz/Unity3DHelperTools.git
```

## Features

You can find example Scenes under "Assets/NikosAssets/U3DHelperTools/Samples/Scenes"

### MonoBehaviours
- Keep the Scene view in focus after pressing the play button:
  
![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/KeepSceneViewInFocus.PNG)

- Look at a target with special settings and constraints:
  
![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/LookAt_Example.gif)

- Alarm clock event emitter:
  
![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/AlarmClock.PNG)

- A generic list/ destination container helper class, emitting events when the list changes:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/DestinationContainer.PNG)

- An async Scene loader helper class, also emitting events:
  
![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/AsyncSceneLoader.PNG)

### Non-MonoBehaviours but here wrapped in sample MonoBehaviour classes 

- EditorUtilitiesHelper, copy or regenerate GUIDs, rename files or generate scripts and open a project only file picker:

![Image](https://raw.githubusercontent.com/niggo1243/Unity3DHelperTools/c09dec59d4029cba63a88cc1a452d66d726efe0d/Assets/NikosAssets/U3DHelperTools/Documentation/EditorUtilities_Example.PNG)

Also available via the toolbar:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/Editor_Toolbar_Helpers.PNG)

- GUIHelper, to draw lines and boxes, in addition to the AlternatingListStyleHelper class:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/GUIHelper_Example.PNG)

Following picture from the <a href="https://assetstore.unity.com/packages/tools/ai/aimalgam-218556">AiMalgam</a> asset (Control Panel):

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/GUIHelper_AiMalgam_ColorBoxAndList.PNG)

- Various extension classes for object cloning, strings, NavmeshAgents, and Coroutines:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/Extensions_Example.PNG)

- Help with Vector, Rigidbody and Quaternion calculations (and other math stuff):

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/NumericHelper_Example.PNG)

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RolyPoly_Example.gif)

- Help with targeting transforms by distance:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/TargetingHelper_Example.PNG)

- Generating random points in the 3D environment:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RandomPointsHelper_Example.PNG)

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/RandomPoints_Example.gif)

- Mapping strings to hashes:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/StringHasher_Example.PNG)

- Offering some helpful methods for collections generally:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/CollectionHelper_Example.PNG)

- Handy methods to retrieve type informations via reflection calls:

![Image](https://github.com/niggo1243/Unity3DHelperTools/raw/master/Assets/NikosAssets/U3DHelperTools/Documentation/ReflectionHelper_Example.PNG)



