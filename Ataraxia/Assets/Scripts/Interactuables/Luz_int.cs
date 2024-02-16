using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz_int : Interactuar
{
    public Light laLuz;
    public override void Activar()

    {
        

        if (laLuz.gameObject.activeInHierarchy)
        {
            laLuz.gameObject.SetActive(false);
            nombreAccion = "Encender";
        }
        else
        {
            laLuz.gameObject.SetActive(true);
            nombreAccion = "Apagarr";
        }
    }
}