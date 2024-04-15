using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityChange : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movPlayer;
    public Transform holder;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal")*speed, rb.velocity.y);
        rb.velocity = movPlayer;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
            //holder.localScale = new Vector2(holder.localScale.x, holder.localScale.y * -1);
        }
    }
}
