using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public Vector2 destino, destino2;
    public float velEnemigo;
    public bool der;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (der)
        {
            transform.position = Vector2.MoveTowards(transform.position, destino, Time.deltaTime * velEnemigo);

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, destino2, Time.deltaTime * velEnemigo);
        }
    }

}
