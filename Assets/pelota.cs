using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    //La etiqueta public antes de una variable nos permite verla en el editor
    public float velX, velY;//Velocidad de mi pelota
    Rigidbody2D pelotaRB;//Fisicas de mi pelota

    void Start()
    {
        velX = Random.Range(2,5);//Calculamos un numero random entre -2,5
        velY = Random.Range(-5, 5);//Calculamos un numero random entre -5,5
        pelotaRB = GetComponent<Rigidbody2D>();//Obtengo el rigidBody
        pelotaRB.velocity=new Vector2 (velX, velY);//Asigno las velocidades random
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pelotaRB.velocity = Vector2.zero;//Congelo la pelota
        transform.position = Vector3.zero;//La regresamos al centro
        Debug.Log("GOL");
    }

}
