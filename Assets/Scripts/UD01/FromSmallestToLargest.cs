using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{

    //Zona de variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        _isAscendingNumber();
    }

    private void _isAscendingNumber()
    {

        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("El orden ascendente es: " + NumberOne + ", " + NumberTwo + ", " + NumberThree);
        }
        else if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("El orden ascendente es: " + NumberThree + ", " + NumberTwo + ", " + NumberOne);
        }
        else if (NumberTwo > NumberThree && NumberThree > NumberOne)
        {
            Debug.Log ("El orden ascendente es: " + NumberOne + ", " + NumberThree + ", " + NumberTwo);
        }
        else if (NumberThree > NumberOne && NumberOne > NumberTwo)
        {
            Debug.Log("El orden ascendente es: " + NumberTwo + ", " + NumberOne + ", " + NumberThree);
        }
        else if (NumberThree > NumberTwo && NumberTwo < NumberOne)
        {
            Debug.Log("El orden ascendente es: " + NumberTwo + ", " + NumberThree + ", " + NumberOne);
        }
        else if (NumberTwo > NumberThree && NumberThree < NumberOne)
        {
            Debug.Log("El orden ascendente es: " + NumberThree + ", " + NumberOne + ", " + NumberTwo);
        }
    }
}
