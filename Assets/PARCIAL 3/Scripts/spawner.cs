using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject enemy;
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
            yield return new WaitForSeconds(5);
            Instantiate(enemigo,transform.position,Quaternion.identity);
            yield return new WaitForSeconds(3);
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
      
    }
}
