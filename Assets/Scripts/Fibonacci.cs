using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    //Variable global
    public int Position;


    // Start is called before the first frame update
    void Start()
    {
        if (_getFibonacciNumber(Position) == -1)
        {
            Debug.Log("Introduce un valor mayor a 0.");
        }
        else
        {
            Debug.Log("La posición " + Position + " corresponde al valor " + _getFibonacciNumber(Position));
        }
    }

    private int _getFibonacciNumber(int position)
    {

        int numberOne = 0,
            numberTwo = 1,
            adittion = 0;

        if (position > 0)
        {
            adittion = numberTwo;

            for (int i = 1; i < position; i++)
            {
                adittion = numberOne + numberTwo;
                numberOne = numberTwo;
                numberTwo = adittion;
            }

            return adittion;
        }

         return -1;
    }
}
