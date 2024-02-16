using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_int : Interactuar
{
    public GameObject obj;
    public override void Activar()

    {


        if (obj.gameObject.activeInHierarchy)
        {
            obj.gameObject.SetActive(false);
            nombreAccion = "Encender";
        }
        else
        {
            obj.gameObject.SetActive(true);
            nombreAccion = "Apagarr";
        }
    }
}
    
