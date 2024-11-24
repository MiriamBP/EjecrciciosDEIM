using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAttack : MonoBehaviour
{
    //Zona de variables globales
    private Animator _anim;
    //esto hace referencia al collider de la espada
    public Collider ColliderAttack;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        //Ejecutar animación
        _anim.SetTrigger("Attack");
    }

    //Eventos en la animación
    private void EnableCollider()
    {
        //habilitar el componenete para que 
        //el collider actue en la escena
        ColliderAttack.enabled = true;
    }

    private void DisableCollider()
    {
        //deshabilitar el componente para que el
        //collider actue en la escena
        ColliderAttack.enabled = false;
    }
}
