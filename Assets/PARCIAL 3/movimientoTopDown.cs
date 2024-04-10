using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class movimientoTopDown : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movPlayer;
    public float speed,balaSpeed;
    public Transform spawnBala;
    public GameObject bala;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = movPlayer*speed;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject b = Instantiate(bala, spawnBala.position, Quaternion.identity);
            b.GetComponent<Rigidbody2D>().AddForce(Vector2.right*balaSpeed,ForceMode2D.Impulse);
            Destroy(b, 2f);
        }
    }
}
