using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Zona de variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        _isDescendingNumber();
    }

    private void _isDescendingNumber()
    {

        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("El orden descendente es: " + NumberThree + ", " + NumberTwo + ", " + NumberOne);
        }
        else if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("El orden descendente es: " + NumberOne + ", " + NumberTwo + ", " + NumberThree);
        }
        else if (NumberTwo > NumberThree && NumberThree > NumberOne)
        {
            Debug.Log("El orden descendente es: " + NumberTwo + ", " + NumberThree + ", " + NumberOne);
        }
        else if (NumberThree > NumberOne && NumberOne > NumberTwo)
        {
            Debug.Log("El orden descendente es: " + NumberThree + ", " + NumberOne + ", " + NumberTwo);
        }
        else if (NumberThree > NumberTwo && NumberTwo < NumberOne)
        {
            Debug.Log("El orden descendente es: " + NumberOne + ", " + NumberThree + ", " + NumberTwo);
        }
        else if (NumberTwo > NumberThree && NumberThree < NumberOne)
        {
            Debug.Log("El orden descendente es: " + NumberTwo + ", " + NumberOne + ", " + NumberThree);
        }
    }
}