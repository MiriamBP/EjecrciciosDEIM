using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GirlMovement : MonoBehaviour
{
    //Zona de variables globales

    //velocidad y velocidad de giro
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    //ejes(en que sentidos se mueve)
    private float _horizontal,
                  _vertical;

    //La variable _anim apunta al componente Animator
    //del gameobject que lleve este script
    private Animator _anim;
    //llamo al rigidbody del personaje que tenga este script
    private Rigidbody _rb;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                _canPlayerJump;

    [Header("Raycast")]
    //capa donde va a actuar el raycast
    public LayerMask GroundMask;
    //longitud del raycast
    public float RayLenght;
    [Header("Jump")]
    public float JumpForce;

    
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    }

    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canPlayerJump)
        {
            _canPlayerJump = false;
            //llamar al método jump
            Jump();
        }
    }

    private void LaunchRaycast()
    {
        //punto de pivote
        _ray.origin = transform.position;
        //hacia abajo
        _ray.direction = -transform.up;

        if(Physics.Raycast(_ray, out _hit, RayLenght))
        {
            //puedo saltar
            _isGrounded = true;
            Debug.Log("Estoy tocando suelo.");
        }
        else
        {
            _isGrounded = false;
        }

        Debug.DrawRay(_ray.origin, _ray.direction * RayLenght, Color.red);
    }

    private void CanJump()
    {
        //Si quiero saltar Y puedo saltar
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _canPlayerJump = true;
        }
    }

    private void Jump()
    {
        _rb.AddForce(Vector3.up * JumpForce);
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

    private void Animating()
    {
        if(_vertical != 0)//El perosonaje se esá moviendo
        {
            _anim.SetBool("IsMoving", true);
        }
        else
        {
            _anim.SetBool("IsMoving", false);
        }
    }
}
