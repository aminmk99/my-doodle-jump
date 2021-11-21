using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float jump = 25f ;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                Vector2 vl = rb.velocity;
                vl.y = jump;
                rb.velocity = vl;
            }
            
        }
        

    }
}
