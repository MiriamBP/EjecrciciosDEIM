using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysExercises : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        _getpositiveNumber();

    }

    private void _getpositiveNumber()
    {
        int[] numbersArray = new int[10] {-15, 4, -30, 17, -3, 60, 90, -24, 19, 0};
        // int[] numbersArray = {-15, 4, -30, 17, -3, 60, 90, -24, 19, 0};

        for (int i = 0; i < numbersArray.Length; i++)
        {
            if(numbersArray[i] >= 0)
            {
                Debug.Log(numbersArray[i]);
            }

        }
    }
}
