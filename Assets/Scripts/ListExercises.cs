using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        _getPositiveNumbers();
    }

    private void _getPositiveNumbers()
    {
        List<int> numbersList = new List<int>() { 0, -23, 34, 42, -19, 72, -81, -3, 69, 5};

        numbersList.Add(6);

        foreach (int number in numbersList)
        {
            if (number >= 0)
            {
                Debug.Log(number);
            }

            
        }

        
    }
}
