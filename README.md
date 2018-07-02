# capture-sequence-extractor

1. Place main / prefabs / ContentsCamera where you want to see the scene, like the main camera.

2. Place main / prefabs / wrapper anywhere you want.

3. fill in the Content component of the ContentsCamera.

  - Head : main/Head
  - TimeWarpingCamera : main/Head/TimeWarpingCamera
  - Anchor : main/Anchor

4. Please set handler.

  - IsTimeWarping : set whether or not to time warp.

  - IsPredicting : set whether or not to predict.

  - Folder : set the path of the captured file.

  - Capture Length : set the maximum number of captures.

  - Capture Height , Capture Width :  set the resolution of the captured file.