using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mng : MonoBehaviour
{
    public GameObject prefab;
    public int countPlat = 200;

    void Start()
    {
        Vector3 pos = new Vector3() ;
        for(int i = 0; i < countPlat; i++)
        {
            pos.y += Random.Range(.1f,5f);
            pos.x = Random.Range(-10f, 10f);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
