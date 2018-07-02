# prediction-playback-plugin

- How to use

1. Import the csv file into the prediction-playback-plugin folder.

2. Place prefabs / PlaybackCamera where you want to see the scene, like the main camera.

3. Place prefabs / CaptureModule anywhere you want.

4. Place prefabs / Handler anywhere you want.

5. Write the name of the csvfile in the csvName of the handler.

6. Fill in the Content component of the PlaybackCamera 

  - Head : CaptureModule/Head
  - TimeWarpingCamera : CaptureModule/Head/TimeWarpingCamera
  - Anchor : CaptureModule/Anchor

7. Set handler.

  - IsTimeWarping : set whether or not to time warp.

  - Folder : set the path of the captured file.

  - Capture Length : set the maximum number of captures.

  - Capture Height , Capture Width :  set the resolution of the captured file.
    (If do not work, set the resolution of the editor game view to standalone.)

8. Press the play button on the editor.


And You can export all files that require the prediction-playback-plugin using the top menu's clicked / export.





























onAirVR Server for Unity current release os graphics
Make your PC VR game wirelessly playable!

onAirVR makes a mobile VR device act as a wireless VR HMD for a desktop by streaming video/audio which are rendered in realtime on the desktop to onAirVR mobile apps. This is the plugin for developing onAirVR contents on Unity game engine.

Before Getting Started
onAirVR consists of two applications - mobile VR client app & content app on PC.

Please ensure you have right hardwares :

Google Daydream or Oculus Mobile device
Windows desktop powered by NVIDIA graphics
This plugin is for PC content development, and the plugins for mobile VR platforms we supports are belows :

onAirVR Client for Oculus Mobile
onAirVR Client for Google VR
Downloads
You can download the pre-exported package for each version from Releases.

You may clone this whole project. It is worth noting that the project itself is maintained on Unity 5.6.5f1 which is the lowest compatible version, but it is safely migrated to higher versions of Unity.

User Guide
System Requirements
Quick Start
Programming Guide
Build
Best Practices
API References
License
onAirVR Server for Unity is MIT licensed.

It also contains our own license file for security. This license has the expiration date and we are going to update the file regularly so that the latest one never expires. Note that the current license expires on 2018-12-31.

Contact
Website : https://onairvr.io
User Forum : https://www.reddit.com/r/onairvr/
Email : contact@onairvr.io
We are Clicked, Inc. : http://clicked.co.kr