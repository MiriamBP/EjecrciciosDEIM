using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggClone : MonoBehaviour
{
    //Zona de variables globales
    public GameObject Egg;
    public Transform PosRotEgg;
    private float _eggTime = 5.0f;

    // Update is called once per frame
    void Update()
    {
        CreateEggs();
    }

    private void CreateEggs()
    {
        //Crear clones del prefabricado de huevo
        //si hago clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            GameObject eggClone = Instantiate(Egg, PosRotEgg.position, PosRotEgg.rotation);

            //Eliminarlos después de 5seg
            Destroy(eggClone, _eggTime);
        }
    }
}
