using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarsToEuros : MonoBehaviour
{
    //Variables glovales
    private float _euro;
    public float Dollar;


    // Start is called before the first frame update
    void Start()
    {
        
        _euro = 0.90f;

        Debug.Log(_getDollarToEuro());
    }

    private float _getDollarToEuro()
    {
        //Variables locales
        float conversion = 0.0f;

        //Calcular la conversión de dólares a euros
        conversion = Dollar * _euro;

        //Delvolver el valor de tipo "float"
        return conversion;




    }
}
