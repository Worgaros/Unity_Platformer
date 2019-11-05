using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    Rigidbody2D body;

    Vector2 direction = new Vector2(1, 0);
    
    Vector2 minPosition;
    Vector2 maxPosition;

    private const float movingLength = 2.17f;
    
    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();
        
        if (body != null) {
            Debug.Log("Moving Platform's Body founded!");
        } else {
            Debug.Log("No body");
        }
        
        minPosition = body.position;
        maxPosition.x = (body.position.x + movingLength);
    }

    void FixedUpdate() {
        body.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (body.position.x >= maxPosition.x) {
            direction.x = -1;
        } else if(body.position.x <= minPosition.x) {
            direction.x = 1;
        }
    }
}