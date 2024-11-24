using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    //Zona de variables globales
    //Desplazamiento
    private float _speed = 1.5f,
                  _turnSpeed = 200.0f,
                  _horizontal,
                  _vertical;

    //Salto
    [SerializeField]
    private LayerMask GoundMask;
    private float _rayLenght = 0.15f;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                 _canPlayerJump;
    private float _jumpForce = 200.0f;
    private Rigidbody _rb;

    //Animaciones
    private Animator _anim; 

    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canPlayerJump)
        {
            _canPlayerJump = false;

            Jump();
        }
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        Turn();
        Move();
        InputWolf();
        CanJump();
        AnimatingRun();
        
    }

    private void InputWolf()
    {
        //A, D y flechas izquierda y derecha
        _horizontal = Input.GetAxis("Horizontal");
        //W, S y flechas arriba y abajo
        _vertical = Input.GetAxis("Vertical");
        
    }

    private void Turn()
    {
        //Aplicamos el valor del eje horizontal al rotate
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }

    private void Move()
    {
        //Aplicamos el valor del eje vertical al translate
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
    }

    //Rayo de salto
    private void LaunchRaycast()
    {
        //Punto de vivote del rayo
        _ray.origin = transform.position;
        //Dirección hacia la que va
        _ray.direction = -transform.up;

        if(Physics.Raycast(_ray, out _hit, _rayLenght))
        {
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }

    }

    //Puedo saltar si:
    private void CanJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _canPlayerJump = true;
        }
    }

    //Añado la fuerza de salto
    private void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce);
    }

    //Condiciones para la animación
    private void AnimatingRun()
    {
        if (_vertical != 0)
        {
            _anim.SetBool("IsMoving", true);
        }
        else
        {
            _anim.SetBool("IsMoving", false);
        }
    }
}
