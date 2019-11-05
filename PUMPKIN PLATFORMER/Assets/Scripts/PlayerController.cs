using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D body;
    
    Vector2 direction;
    
    [SerializeField]
    private float speed = 2;
    private float jumpForce = 8;

    bool canJump = false;
    
    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();

        if (body != null) {
            Debug.Log("Player's body founded!");
        } else {
            Debug.Log("No player body");
        }
    }

    void FixedUpdate() {
        body.velocity = direction;
    }
    
    // Update is called once per frame
    void Update() {
        direction = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetAxis("Jump") > 0.1f && canJump) {
            Debug.Log("Jump");
            direction = new Vector2(body.velocity.x, body.velocity.y + jumpForce);

            canJump = false;
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (!canJump)
        { 
            Debug.Log("Enter");
            body.velocity = new Vector2(body.velocity.x, 0);
            canJump = true;
        }
        
    }
}