using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEQ : MonoBehaviour
{
    public static Vector3 Circle(float t, float a =2)
    {
        float x = a * Mathf.Cos(t);
        float y = a * Mathf.Sin(t);
        float z = 0f;
        return new Vector3(x, y, z);
    }

    public static Vector3 Astriod(float t, float a=3)
    {
        float x = a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = a * Mathf.Pow(Mathf.Sin(t), 3);
        float z = 0f;
        return new Vector3(x, y, z);
    }

    public static Vector3 epitrochoid(float t, float a = 4)
    {

    }
}
