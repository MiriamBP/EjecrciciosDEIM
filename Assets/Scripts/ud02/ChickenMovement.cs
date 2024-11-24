using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    //Zona de variables globales
    private float _horizontal,
                  _vertical,
                  _speed = 0.5f,
                  _turnSpeed = 150.0f;

    // Update is called once per frame
    void Update()
    {
        InputChicken();
        Turn();
        Move();
    }

    private void InputChicken()
    {
        //A, D y flechas Izquierda y derecha
        _horizontal = Input.GetAxis("Horizontal");
        //W, S y feclas arriba y abajo
        _vertical = Input.GetAxis("Vertical");

    }

    private void Turn()
    {
        //Aplicamos el valor del eje horizontal al rotate
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);
    }

    private void Move()
    {
        //Aplicamos el valor del eje vertical al translate
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
    }
}
