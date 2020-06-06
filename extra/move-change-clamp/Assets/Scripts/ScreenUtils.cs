using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenUtils
{

    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;


    public static float ScreenLeft
    {
        get { return screenLeft; }
    }


    public static float ScreenRight
    {
        get { return screenRight; }
    }


    public static float ScreenTop
    {
        get { return screenTop; }
    }


    public static float ScreenBottom
    {
        get { return screenBottom; }
    }



    public static void Initialize()
    {
        // save screen edges in world coordinates 
        Vector3 upperRightCornerScreen = new Vector3(Screen.width, Screen.height,
            -Camera.main.transform.position.z);
        Vector3 upperRightCornerWorld = Camera.main.ScreenToWorldPoint(upperRightCornerScreen);

        Vector3 lowerLeftCornerScreen = new Vector3(0, 0,
            -Camera.main.transform.position.z);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);

        screenTop = upperRightCornerWorld.y;
        screenBottom = lowerLeftCornerWorld.y;
        screenRight = upperRightCornerWorld.x;
        screenLeft = lowerLeftCornerWorld.x;

    }


}
