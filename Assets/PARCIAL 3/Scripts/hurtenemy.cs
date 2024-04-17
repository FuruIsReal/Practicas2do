using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtenemy : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("attack"))
        {
            animator.SetTrigger("hurt");
        }
    }
}
