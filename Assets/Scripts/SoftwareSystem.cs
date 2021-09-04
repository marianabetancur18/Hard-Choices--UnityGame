using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoftwareSystem 
{
    public static string state = "alpha";
    public static bool developingState=false;

   public static void updateState()
    {
        state = "betha";
    }

    public static void setDevelopingState(bool b)
    {
        developingState = b;
    }
}
