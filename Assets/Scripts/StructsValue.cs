using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructsValue : MonoBehaviour
{

    //Zona de variables globales
    public Color Mycolor = new Color(0.35f, 0.90f, 0.15f);
    public Color32 MyTrueColor = new Color32(255, 50, 25, 25);
    public Vector2 MyVector2 = new Vector2(1.5f, 2.5f);
    public Vector3 MyVector3 = new Vector3(1.5f, 2.5f, 3.5f);
    public Quaternion MyQuaternion = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
