# prediction-playback-plugin

How to use : 

1. Import the csv file into the prediction-playback-plugin/Resources.

2. Place prefabs / PlaybackCamera where you want to see the scene, like the main camera.

3. Write the name of the csvfile in the csvName of the PlaybackCamera. 

4. Set CSV Simulator in the PlaybackCamera.

  - IsTimeWarping : set whether or not to time warp.

  - IsPredicting : set whether or not to predict.

  - Capture Path : set the path of the captured file.

  - Capture Length : set the maximum number of captures.
 
  - Capture Frame : Advances the game by '1 / Capture Frame' per frame.

  - Capture Width , Capture Height :  set the resolution of the captured file.
    (If do not work, set the resolution of the editor game view to 'Free Aspect')

5. Press the play button on the editor.


And When running in another Unity project, extract the package file using clicked / export and import it from another Unity project.