using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaAnimada : Interactuar
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    public override void Activar()
    {
        animator.SetTrigger("Abrir");
    }


}
