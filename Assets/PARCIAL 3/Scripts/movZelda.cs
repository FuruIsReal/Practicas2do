using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movZelda : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movPlayer;
    public float speed;
    public Animator anims;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anims = GetComponent<Animator>();   
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = movPlayer * speed;

        if (Input.GetButtonDown("Fire1"))
        {
            anims.SetTrigger("attackRight");
        }
    }
}
