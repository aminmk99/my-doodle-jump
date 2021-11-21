using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float jump = 15f ;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>() ;
        if(rb != null)
	{
	    Vector2 vel = rb.velocity ;
            vel.y = jump ;
            rb.velocity = vel ;
	}
    }
}
