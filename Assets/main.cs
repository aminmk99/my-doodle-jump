using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public float speed = 10f ;
    public Rigidbody2D rb ;
    private float x ;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed ;
    }

    void FixedUpdate()
    {
        Vector2 vel = rb.velocity ;
        vel.x = x ;
        rb.velocity = vel ;
    }
}
