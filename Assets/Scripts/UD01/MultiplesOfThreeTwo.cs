using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        _getMultiplesThreeTwo();
    }

    private void _getMultiplesThreeTwo()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                if (i % 3 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }
}
