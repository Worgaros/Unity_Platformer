using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPlayerOutOfMap : MonoBehaviour
{
    private Rigidbody2D body;
    
    private const float maxLeft = -3.265f;
    private const float maxUp = 2.624f;
    private const float maxRight = 3.231f;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
        if (body != null) {
            Debug.Log("Body founded!");
        } else {
            Debug.Log("No body");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (body.position.x <= maxLeft)
        {
            body.velocity = new Vector2(0, body.position.y);
        }
        
        if (body.position.x <= maxRight)
        {
            body.velocity = new Vector2(0, body.position.y);
        }
        
        if (body.position.y >= maxUp)
        {
            body.velocity = new Vector2(body.position.x, 0);
        }
    }
}
