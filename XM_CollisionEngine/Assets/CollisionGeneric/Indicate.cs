﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicate : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }
    public void setValue(bool col)
    {
        if(col)
        {
            sr.color = new Color(0, 1, 0);
        }else
        {
            sr.color = new Color(1, 0, 0);

        }
    }
}
