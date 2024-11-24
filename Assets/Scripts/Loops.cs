using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //Variables Globales
    public int Number;

    
    // Start is called before the first frame update
    void Start()
    {
        //_getNumbers0To100While(); 
        //_getNumbers0To100For();
        //_getNumber100To0While();
        //_getNumber100To0For();
        //_getNumber1ToXWhile();
        _getNumber1ToXFor();
    }

    private void _getNumbers0To100While()
    {
        //Crear e inicializar la variable de incremento
        int i = 0;

        //Crear el "While"
        while (i <= 100)
        {
            Debug.Log(i);
            i++;
        }
    }

    private void _getNumbers0To100For()
    {
        for (int i = 0; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    private void _getNumber100To0While()
    {
        int i = 100;

        while (i >= 0)
        {
            Debug.Log(i);
            i--;

        }
    }
    

    private void _getNumber100To0For()
    {
        for (int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }
        
    }

    private void _getNumber1ToXWhile()
    {
        int i = 1;
        
        while (i <= Number)
        {
            Debug.Log(i);
            i++;
        }
    }

    private void _getNumber1ToXFor()
    {
       for(int i = 1; i <= Number; i++)
        {
            Debug.Log(i);
        }
    }
}
