using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfo : MonoBehaviour
{
    public Transform t;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t.position.y > transform.position.y)
        {
            Vector3 pos = new Vector3(transform.position.x, t.position.y, transform.position.z);
            transform.position = pos;
        }
    }
}
