using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Clone : MonoBehaviour
{

    //Zona de variables globales
    public GameObject Acorn;
    public Transform PosRotAcorn;

    public float ThrustY,
                 ThrustZ;

    private float _timeAcorn = 3.0f;
    private float _timeInvoke = 2.0f;
    private float _timeRepeating = 5.0f;

    private void Start()
    {
        //Invoke("CreateAcorns", _timeInvoke);
        InvokeRepeating("CreateAcorns", _timeInvoke, _timeRepeating);
    }

    // Update is called once per frame
    void Update()
    {
        //CreateAcorns();

    }

    private void CreateAcorns()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //Crear clones del prefabricado de la bellota
        //Como no le indico donde quiero que genere las bellotas
        //Estas van a aparecer en la posición (0.0f, 0.0f, 0.0f)
        GameObject cloneAcorn = Instantiate(Acorn, PosRotAcorn.position, PosRotAcorn.rotation);

        //Obtengo el compoente rigibody de cada ellota
        Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();

        //Vector3.up hace referencia al eje Y global de la escena
        rbAcorn.AddForce(Vector3.up * ThrustY);

        //transform.forward hace referencia al eje Z local de PosRotAcorn
        rbAcorn.AddForce(transform.forward * ThrustZ);

        Destroy(cloneAcorn, _timeAcorn);

        // }
    }
}
