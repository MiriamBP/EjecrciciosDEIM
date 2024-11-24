using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour
{
    //Zona de variables globales
    public Transform MyCube;

    

    // Update is called once per frame
    void Update()
    {
        TransformLook();
    }

    private void TransformLook()
    {
        transform.LookAt(MyCube);
    }
}
