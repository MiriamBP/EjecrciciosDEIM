using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        _getMultiplesThree();
    }

    private void _getMultiplesThree()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
