using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    //zora de variables globales
    private float _temperatureOneCelsius,
                  _temperatureTwoFahrenheit;

    


    // Start is called before the first frame update
    void Start()
    {

        _temperatureOneCelsius = 35;
        _temperatureTwoFahrenheit = -12;

        _getCelsiusToFahrenheit();
        _getFahrenheitToCelsius();


    }

    private void _getCelsiusToFahrenheit()
    {
        /*Formula
         * C = (F – 32) /1,8*/

        //Variables locales
        double celsius = 0.0d;

        //conversión
        celsius = (_temperatureTwoFahrenheit - 32) / 1.8;

        //mostrar en consola
        Debug.Log(_temperatureTwoFahrenheit + " farenheit es igual a " + celsius + " celsius");
    }

    private void _getFahrenheitToCelsius()
    {
        /*Formula
         * F = (1,8) * C + 32*/

        //variables locales
        double farenheit = 0.0d;

        //conversión
        farenheit = (1.8) * _temperatureOneCelsius + 32;

        //mostrar en consola
        Debug.Log(_temperatureOneCelsius + " celsius es igual a " + farenheit + " farenheit");
    }
}
