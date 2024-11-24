using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activated : MonoBehaviour
{
    //Zona e variables globales
    public GameObject MyCamera;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ActivateCamera(); 
    }

    private void ActivateCamera()
    {
        if(Input.GetKeyDown(KeyCode.Space))

                MyCamera.SetActive(false);

        if(Input.GetKeyDown(KeyCode.E))

                MyCamera.SetActive(true);
    }


}
