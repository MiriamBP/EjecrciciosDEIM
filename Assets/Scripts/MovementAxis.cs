using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxis : MonoBehaviour
{

    //Zona de variables globales
    private float _horizontal;
    private float _vertical;
    private float _speed = 0.8f;
    private float _turnSpeed = 90.0f;

    // Update is called once per frame
    void Update()
    {
        InputCube();

    }

    private void InputCube()
    {
        //A D flechas izquierda y dercha
        _horizontal = Input.GetAxis("Horizontal");
        //W S feclas arriba y abajo
        _vertical = Input.GetAxis("Vertical");

        //Aplicamos el valor del eje vertical al translate
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

        //Aplicamo el valor del eje horixontal al rotate
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);
    }
}
