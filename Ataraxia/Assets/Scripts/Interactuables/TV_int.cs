using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_int : Interactuar
{
    public GameObject Encendido;
    public override void Activar()

    {


        if (Encendido.gameObject.activeInHierarchy)
        {
            Encendido.gameObject.SetActive(false);
            nombreAccion = "Encender TV";
        }
        else
        {
            Encendido.gameObject.SetActive(true);
            nombreAccion = "Apagar";
        }
    }
}