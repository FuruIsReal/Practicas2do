using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class pelota : MonoBehaviour
{
    //La etiqueta public antes de una variable nos permite verla en el editor
    public float velX, velY;//Velocidad de mi pelota
    Rigidbody2D pelotaRB;//Fisicas de mi pelota
    public int puntospan, puntosfederico;
    public TextMeshProUGUI textopuntospan, textopuntosfederico;
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
        puntospan++;
        textopuntospan.text = "Pan: "+puntospan;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            velX *= -1.1f;
            pelotaRB.velocity = new Vector2(velX, pelotaRB.velocity.y);

        }

        if (collision.gameObject.CompareTag("Murillo"))
        {
            velY *= -1;
            pelotaRB.velocity = new Vector2(pelotaRB.velocity.x, velY);
        }

        
    }

    private void Update()
    {
        if (pelotaRB.velocity==Vector2.zero) 
        {
            velX = Random.Range(2, 5);
            velY = Random.Range(-5, 5);
            pelotaRB.velocity = new Vector2(velX, velY);
        }
    }




}
