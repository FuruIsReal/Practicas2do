using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Animator animPlayer;
    public float velPlayer=10f;//velocidad del player
    Vector2 movPlayer;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();//Obtenemos el RB para movernos
        animPlayer = GetComponent<Animator>();//Obtenemos el animator para animar  
    }

    void Update()
    {
        movPlayer = new Vector2(Input.GetAxis("Horizontal") * velPlayer, rbPlayer.velocity.y);
        rbPlayer.velocity = movPlayer;

        if (Input.GetAxis("Horizontal") != 0)
        {
            animPlayer.SetBool("run", true);
        }
        else
        {
            animPlayer.SetBool("run", false);
        }
    }
}
