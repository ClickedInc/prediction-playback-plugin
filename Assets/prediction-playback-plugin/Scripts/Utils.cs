﻿using System;
using UnityEditor;
using UnityEngine;

public static class Utils
{
    public enum GameViewSizeType
    {
        AspectRatio, FixedResolution
    }

    public static void AddTestSize(int width,int height)
    {
        AddCustomSize(GameViewSizeType.AspectRatio, GameViewSizeGroupType.Standalone, width, height, "size");
    }

    public static void AddCustomSize(GameViewSizeType viewSizeType, GameViewSizeGroupType sizeGroupType, int width, int height, string text)
    {
        // goal:
        // var group = ScriptableSingleton<GameViewSizes>.instance.GetGroup(sizeGroupType);
        // group.AddCustomSize(new GameViewSize(viewSizeType, width, height, text);

        var asm = typeof(Editor).Assembly;
        var sizesType = asm.GetType("UnityEditor.GameViewSizes");
        var singleType = typeof(ScriptableSingleton<>).MakeGenericType(sizesType);
        var instanceProp = singleType.GetProperty("instance");
        var getGroup = sizesType.GetMethod("GetGroup");
        var instance = instanceProp.GetValue(null, null);
        var group = getGroup.Invoke(instance, new object[] { (int)sizeGroupType });
        var addCustomSize = getGroup.ReturnType.GetMethod("AddCustomSize"); // or group.GetType().
        var gvsType = asm.GetType("UnityEditor.GameViewSize");
        var ctor = gvsType.GetConstructor(new Type[] { typeof(int), typeof(int), typeof(int), typeof(string) });
        var newSize = ctor.Invoke(new object[] { (int)viewSizeType, width, height, text });
        addCustomSize.Invoke(group, new object[] { newSize });
    }
}
