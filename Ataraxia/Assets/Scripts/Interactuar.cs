using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactuar : MonoBehaviour
{
    public string nombreAccion;//promt
    //ESte metodo es abstracto, promesa de la accion a realiar, se define en una clase quue tarea se hara
    public abstract void Activar();
    public bool enContacto = false;

    //condicionar si es el jugdor quien lo toca
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }
        //Solicito al UI que muestre el promt de este objeto
        Controladorui.Instancia.MostrarInteractuable(this);
        enContacto = true;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && enContacto)
        {
            Activar();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Controladorui.Instancia.MostrarInteractuable(null);
        enContacto = false;
    }

}
