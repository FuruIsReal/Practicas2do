using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalacioAmlo : MonoBehaviour
{
    public GameObject Prefabfurro;
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        { 
         yield return new WaitForSeconds(1);
         Instantiate(Prefabfurro,transform.position,Quaternion.identity);
        }
    }
}
