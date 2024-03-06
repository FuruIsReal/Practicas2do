using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Animator animPlayer;
    public float velPlayer=10f;//velocidad del player
    public float jumpForce=100f;//fuerza de brinco
    bool brincando;
    public GameObject balaprefab;
    Vector2 movPlayer;
    public Transform spawnBala;
    bool facingRight=true;
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
            if (brincando == false)
            {
            animPlayer.SetBool("run", true);
            }
            if(Input.GetAxis("Horizontal") > 0)
            {
                transform.localScale=new Vector3(1, 1, 1);
                facingRight = true;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                facingRight = false;
            }
        }
        else
        {
            animPlayer.SetBool("run", false);
        }

        if (Input.GetButtonDown("Jump") && brincando== false)
        {
            brincando = true;   
            animPlayer.SetBool("jump",true);
            rbPlayer.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animPlayer.SetBool("shoot",true);
            //Instantiate(balaprefab,spawnBala.position,Quaternion.identity);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            animPlayer.SetBool("shoot", false);
        }

    }

    public void ataquePlayer()
    {
        GameObject bala=Instantiate(balaprefab, spawnBala.position, Quaternion.identity);
        if (facingRight==false)
        {
            bala.GetComponent<bala>().balaSpeed *= -1;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo")){
            brincando = false;
            animPlayer.SetBool("jump", false);
        }
    }
}
