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
            transform.position = new Vector3(-1.9f,1.4f,11f);
            Abierto = true;
            nombreAccion = "Cerrar";
        }
        else
        {
            transform.position = new Vector3(-1.7f, 1.7f, 11f);
            Abierto = false;
            nombreAccion = "Abrir";
        }


    }
}
