using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida_int : Interactuar
{
    public GameObject Comida;
    public override void Activar()

    {


        if (Comida.gameObject.activeInHierarchy)
        {
            Comida.gameObject.SetActive(false);
            nombreAccion = "Comer";
        }

    }
}