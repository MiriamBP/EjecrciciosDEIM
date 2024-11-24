using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Zona de variables globales
    public Transform Target;
    //Velocidad de seguimiento
    private float _smoothing;
    //Distancia inicial entre el target y la cámara
    private Vector3 _offset;


    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - Target.position;
        _smoothing = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //La posición a la que quiero mover la cámara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);
    }
}
