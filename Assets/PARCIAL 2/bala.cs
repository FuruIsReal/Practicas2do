using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody2D balaRB;
    public float balaSpeed = 5f;
    void Start()
    {
        balaRB = GetComponent<Rigidbody2D>();
        balaRB.AddForce(Vector2.right * balaSpeed, ForceMode2D.Impulse);
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            Destroy(gameObject);
        }
    }
}
