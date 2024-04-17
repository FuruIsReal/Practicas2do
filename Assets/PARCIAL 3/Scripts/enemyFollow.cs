using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public Transform follow;
    public float speed;
    void Start()
    {
        Destroy(gameObject, 2f);
        speed = Random.Range(2, 6);
        follow=GameObject.Find("MetaEnemigo").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, follow.position, speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meta"))
        {
            Destroy(gameObject);
        }
    }
}
