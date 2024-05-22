using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLife : MonoBehaviour
{
    public int life;

    public bool isEnemy;
    public bool isBoss;
    public bool isHouse;
    

    public GameObject panelVictory;
    public GameObject panelDefeated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {

            if(isBoss)
            {
                panelVictory.SetActive(true);
            }

            if (isHouse) 
            {
                panelDefeated.SetActive(true);
            }

            Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnemy)
        {
            if (collision.gameObject.CompareTag("Bala"))
            {
                life--;
            }

            if (collision.gameObject.CompareTag("suelo"))
            {
                life = 0;
            }

            if (collision.gameObject.CompareTag("Player"))
            {
                life=0;
            }
        }

        if(!isEnemy)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {
                life--;
            }
            if (collision.gameObject.CompareTag("lobo"))
            {
                life -= 2;

            }

            if (collision.gameObject.CompareTag("suelo"))
            {
                life = 0;
            }

        }
    }
}
