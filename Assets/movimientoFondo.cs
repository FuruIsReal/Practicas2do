using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoFondo : MonoBehaviour
{
    public float vel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x-vel,transform.position.y,transform.position.z);
        if(transform.position.x < -60)
        {
            transform.position = new Vector3(60, transform.position.y, transform.position.z);
        }
    }
}
