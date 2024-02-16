using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta_int : Interactuar
{
    public bool Abierto = false;
    public override void Activar()

    {
        if (!Abierto)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            Abierto = true;
            nombreAccion = "Cerrar";
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Abierto = false;
            nombreAccion = "Abrir";
        }
      
       
    }
}
