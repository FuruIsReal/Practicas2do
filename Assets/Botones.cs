using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    // Start is called before the first frame update
    public void abrirEscena(string nombre)//Esta función abre una escena al ser llamada
    {
        SceneManager.LoadScene(nombre);//Aqui colocamos la variable del nombre de la escena
    }


}
