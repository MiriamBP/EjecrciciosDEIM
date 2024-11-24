using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoyMovement : MonoBehaviour
{
    //velocidad y velocidad de giro
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    //ejes(en que sentidos se mueve)
    private float _horizontal,
                  _vertical;


   
    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Move();
        Turn();
    }

    private void InputPlayer()
    {
        //le digo las teclas /// como sale en el Input maneger
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

    }

    private void Move()
    {
        //desplazate hacia delante a esta velocidad
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
    }

    private void Turn()
    {
        //gira hacia los lados a esta velocidad
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }
}
