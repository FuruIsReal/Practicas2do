using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTorres : MonoBehaviour
{
    public GameObject torre;
    void Start()
    {
        
    }

    public void spawnTorre1()
    {
        Instantiate(torre,transform.position,Quaternion.identity);
    }
}
