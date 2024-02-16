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
            transform.position = new Vector3(0,0,-1);
            Abierto = true;
            nombreAccion = "Cerrar";
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
            Abierto = false;
            nombreAccion = "Abrir";
        }


    }
}
