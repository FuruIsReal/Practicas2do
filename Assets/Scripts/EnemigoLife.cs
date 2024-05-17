using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class EnemigoLife : MonoBehaviour
{
    public int life;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            life--;
            //Destroy(gameObject);
        }

        /*
        if (collision.gameObject.CompareTag("enemy"))
        {
            cont++;
            if(cont == 5)
            {
               Destroy(collision.gameObject);
              Destroy(gameObject);
            }
            gm.sumarpuntos(1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        */
    }
}
