using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAttack : MonoBehaviour
{
    //Zona de variables globales
    //Animacion
    private Animator _anim;
    //Tiro
    [SerializeField]
    private GameObject _flower;
    [SerializeField]
    private Transform _posRot;

    private float _thrustY = 50.0f,
                  _thrustZ = 500.0f,
                  _flowerTime = 6.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AttackAnimation();
        }

        Attack();
    }

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Creo clones de flor y digo donde van a aparecer
            GameObject cloneFlower = Instantiate(_flower, _posRot.position, _posRot.rotation);
            //Obtengo el rigidbody de cada flor
            Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();

            //Añado fuerza a las flores
            rbFlower.AddForce(Vector3.up * _thrustY);
            rbFlower.AddForce(transform.forward * _thrustZ);

            //Destruyo las flores
            Destroy(cloneFlower, _flowerTime);
        }
    }

    private void AttackAnimation()
    {
        _anim.SetTrigger("Attack");
    }
}
