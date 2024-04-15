using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movRunGun : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movPlayer;
    public float speed, balaSpeed,jumpForce;
    public Transform spawnBala;
    public GameObject bala;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        rb.velocity = movPlayer;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject b = Instantiate(bala, spawnBala.position, Quaternion.identity);
            b.GetComponent<Rigidbody2D>().AddForce(Vector2.right * balaSpeed, ForceMode2D.Impulse);
            Destroy(b, 2f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
