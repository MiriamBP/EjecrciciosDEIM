using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleRaycast : MonoBehaviour
{
    //Zona de variales globales
    //Variable dónde se guarda la información del rayo
    private Ray _ray;
    //Aquí se guarda la información de la colisión
    //entre el Raycast y el Collider del objeto
    private RaycastHit _hit;
    public float RayLenght;
    public LayerMask RayMask;
    public float ForceEnemy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ray.origin = transform.position;
        //hacia delante, hacia donde mira el personaje
        _ray.direction = transform.forward;

        if (Physics.Raycast(_ray, out _hit, RayLenght, RayMask))
        {
            Debug.Log("Estoy chocando con " + _hit.collider.name);
            Debug.Log("Punto de impacto " + _hit.point);
            Debug.Log("Distancia: " + _hit.distance);
            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceEnemy);
        }
        
        Debug.DrawRay(_ray.origin, _ray.direction * RayLenght, Color.red);
    }
}
