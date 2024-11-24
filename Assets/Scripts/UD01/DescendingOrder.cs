using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Zona de variables globales
    public int NumberOne,
               NumberTwo,
               Numberthree;



    // Start is called before the first frame update
    void Start()
    {
        _isDescendingOrder();
    }

    private void _isDescendingOrder()
    {
        if(NumberOne > NumberTwo && NumberTwo > Numberthree)
        {
            Debug.Log("El orden de los números es decreciente.");
        }
        else
        {
            Debug.Log("El orden de los números no es decreciente.");

        }
    }
}
