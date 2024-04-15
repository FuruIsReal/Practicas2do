using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemigo;
    public bool vivo;
    void Start()
    {
        vivo = true;
        StartCoroutine(spawnEnemigos());
    }

    IEnumerator spawnEnemigos()
    {
        while (vivo==true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemigo,transform.position,Quaternion.identity);
        }
    }
}
