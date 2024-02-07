using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoPong : MonoBehaviour
{
    public Transform posPelota;//Declaramos la posición de la pelota
    // Start is called before the first frame update
    void Start()
    {
      //Aqui podriamos obtener la posición de la pelota pero hoy veremos
      //OTRO METODO para hacerlo
    }

    // Update is called once per frame
    void Update()
    {
        //Esto hace que sigamos todo el tiempo en Y a la pelota
        transform.position = new Vector2(transform.position.x,posPelota.position.y);
    }
}
