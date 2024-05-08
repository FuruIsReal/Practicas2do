using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ataqueTiming : MonoBehaviour
{
    public Transform target,posPlayer;
    public float speed;
    public bool attacking,canAttack,vuelta;
    void Start()
    {
        canAttack = true;
    }

    void Update()
    {
        if (attacking)
        {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (vuelta)
        {
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, speed * Time.deltaTime);
        }
    }

    public void ataque()
    {
        if (canAttack) 
        {
            attacking = true;
            canAttack = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            attacking=false;
            vuelta = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("posplayer"))
        {
            vuelta = false;
            canAttack=true;
        }
    }
}
