using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int puntos;
    public TextMeshProUGUI textopuntos;
    // Start is called before the first frame update
    void Start()
    {
        textopuntos.text = "Puntos: " + puntos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sumarpuntos(int p)
    {
        puntos += p;
        textopuntos.text = "Puntos: " + puntos;
    }
}
