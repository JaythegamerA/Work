﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveB : MonoBehaviour
{
    public float scale = 1;
    private void FixedUpdate()
    {
        float mvs = scale * Time.deltaTime;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));
        transform.position += move;

    }
}
