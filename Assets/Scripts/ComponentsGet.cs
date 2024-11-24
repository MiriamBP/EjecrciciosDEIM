using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsGet : MonoBehaviour
{

    //Zona de variables globales
    private Light _myLight;
    public BoxCollider BoxColliderCube;

    private void Awake()
    {
        //Inicicalización del componente Light
        _myLight = GetComponent<Light>();
        BoxColliderCube.enabled = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        _myLight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
