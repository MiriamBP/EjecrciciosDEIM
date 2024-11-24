using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Zona de variables globales
    public int Number;

    // Start is called before the first frame update
    void Start()
    {

       Debug.Log(_getAddition());
            
    }

    private int _getAddition()
    {

        int addition = 0;
    
        for (int i = 0; i <= Number; i++)
        {

            addition = addition + i; 
        }

        return addition;
    }
}
