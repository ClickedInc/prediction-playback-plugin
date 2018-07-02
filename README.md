# prediction-playback-plugin

How to use : 

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