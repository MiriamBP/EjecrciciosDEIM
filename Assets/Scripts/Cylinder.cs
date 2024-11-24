using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilinder : MonoBehaviour
{
    //Zona de variables globales
    private float _height,
                  _radius;


    // Start is called before the first frame update
    void Start()
    {

        _height = 15.0f;
        _radius = 4.0f;

        _getArea();
        _getVolume();

    }

    private void _getArea()
    {
        //variables locales
        float area = 0.0f;

        //calcular el area
        area = (2 * Mathf.PI * _radius * _height) + 2 * (Mathf.PI * Mathf.Pow(_radius, 2));

        //mostrar por consola
        Debug.Log("El area de mi cilindro es: " +  area);
    }

    private void _getVolume()
    {
        //variables locales
        float volume = 0.0f;

        //calcular volumen
        volume = Mathf.PI * Mathf.Pow(_radius, 2) * _height;

        //mostrar por consola
        Debug.Log("El volumen de mi cilindro es: " + volume);
    }
    
}
