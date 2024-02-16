using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Este va en el canvas

public class Controladorui : MonoBehaviour
{
    public static Controladorui Instancia;

    public GameObject grupoPromtInteraccion;
    public TextMeshProUGUI textoPrompt;
    void Start()
    {
        Instancia = this;

    }

    public void MostrarInteractuable(Interactuar obj)
    {
        if (obj != null)
        {
            grupoPromtInteraccion.SetActive(true);
            textoPrompt.text = obj.nombreAccion;
        }
        else
        {
            grupoPromtInteraccion.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
