using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajom_int : Interactuar
{ 
    public bool Abierto = false;
    public override void Activar()

    {
        if (!Abierto)
        {
            transform.position = new Vector3(-1.5f,1f,11);
            Abierto = true;
            nombreAccion = "Cerrar";
        }
        else
        {
            transform.position = new Vector3(-1, 1, 11);
            Abierto = false;
            nombreAccion = "Abrir";
        }


    }
}
