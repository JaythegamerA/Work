using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker4move : MonoBehaviour
{
    TrailRenderer TR;

    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Hypocycloid(0);
        TR.enabled = true;

    }

    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Hypocycloid(5 * t);
    }
}
