using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    public void abrirEscena(string nombre)//Esta funci�n abre una escena al ser llamada
    {
        SceneManager.LoadScene(nombre);
    }


}
