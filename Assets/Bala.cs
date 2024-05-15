using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody2D balaRB;
    public float balaSpeed = 5f;
    public GameObject gameManager;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        balaRB = GetComponent<Rigidbody2D>();
        balaRB.AddForce(Vector2.up * balaSpeed, ForceMode2D.Impulse);
        Destroy(gameObject, 2);
        gameManager = GameObject.Find("gm");
        gm=gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            gm.sumarpuntos(1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            gm.sumarpuntos(1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}