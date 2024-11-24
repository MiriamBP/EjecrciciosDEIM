using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        _getOddNumbers();
    }

    private void _getOddNumbers()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
