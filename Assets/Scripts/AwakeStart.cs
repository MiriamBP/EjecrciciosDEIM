using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Soy el awake y me ejecuto en primer lugar: " + Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soy el start y me ejeecuto en segundo lugar: " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy el update y me ejecuto en cuato luegar: " + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("Soy el fixedupdate y me ejecuto en tercer lugar: " + Time.deltaTime);
    }

}
