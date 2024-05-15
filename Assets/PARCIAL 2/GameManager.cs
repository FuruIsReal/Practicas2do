using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int puntos;
    public TextMeshProUGUI textopuntos;
    void Start()
    {
        textopuntos.text = "Puntos: " + puntos ;
    }
    public void sumarpuntos(int p)
    {
        puntos += p ;
        textopuntos.text = "Puntos: " + puntos;
    }
}
