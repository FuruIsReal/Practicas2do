using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSpaceInvaders : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movPlayer;
    public float speed, balaSpeed;
    public Transform spawnBala;
    public GameObject bala;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal"), 0);
        rb.velocity = movPlayer * speed;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject b = Instantiate(bala, spawnBala.position, Quaternion.identity);
            b.GetComponent<Rigidbody2D>().AddForce(Vector2.up * balaSpeed, ForceMode2D.Impulse);
            Destroy(b, 2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
