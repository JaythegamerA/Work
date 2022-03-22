using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{

    Vector2 velocityVector;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        velocityVector = new Vector2(1, 1);
        rb.velocity = velocityVector;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
