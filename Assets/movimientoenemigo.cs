using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public Vector2 destino, destino2;
    public float velEnemigo;
    public bool der;
    Animator animPlayer;
    bool spawn;
    // Start is called before the first frame update
    void Start()
    {
        animPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (der)
        {
            transform.position = Vector2.MoveTowards(transform.position, destino, Time.deltaTime * velEnemigo);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, destino2, Time.deltaTime * velEnemigo);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (spawn == true)
        {
            animPlayer.SetBool("spawn", true);
        }
        if(spawn == false)
        {
            animPlayer.SetBool("spawn", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cambio"))
        {
            der=!der;
        }
    }

}
