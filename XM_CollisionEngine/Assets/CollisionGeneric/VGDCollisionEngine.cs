using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VGDCollisionEngine : MonoBehaviour
{
    public static bool PointPoint(float ax, float ay, float bx, float by)
    {
        if(ax==bx&&ay==by)
        {
            return true;
        }
        return false;
    }

    public static bool PointPointBuffer(float ax, float ay, float bx, float by, float buffer)
    {
        float diffx = ax - bx;
        float diffy = ay - by;
        if (Mathf.Abs(diffx)<buffer&&Mathf.Abs(diffy)<buffer)
        {
            return true;
        }
        return false;
    }
}    
