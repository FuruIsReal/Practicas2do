using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public Vector2 destino, destino2;
    public float velEnemigo;
    public bool der;
    Animator aniMonster;
    bool spawn;
    private string currentState;

    public const string Monster_Walk = "Caminar";
    public const string Monster_Spawn = "spawn";
    public bool ismoving;
    public bool isSpawing;

    public float temporizador;
    public float timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        aniMonster = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        temporizador += Time.deltaTime;

        if(temporizador >= 5)
        {
            temporizador = 0;
            isSpawing = true;
        }

        if(ismoving && !isSpawing)
        {
            ChangeAnimationState(Monster_Walk);

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

        }
        
        if(isSpawing)
        {
            ismoving = false;
            ChangeAnimationState(Monster_Spawn);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cambio"))
        {
            der = !der;
        }
        
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        aniMonster.Play(newState);
        currentState = newState;
    }

    public void Finish_Spawn()
    {
        isSpawing = false;
        ismoving = true;
    }
}