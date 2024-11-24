using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
        
    //Zona de variables glovales
    public int IntegerNumber = 0;
    public float StudentGrade = 8.5f; //8.0f
    public string StudentName = "Raquel";
    public bool IsAnActiveStudent = true;
    public char Password = '*';
    public long BigNumber = 738882726459099383;
    public double BigStudentGrade = 7.666d;
    public byte LittleNumber = 255;


    // Start is called before the first frame update
    void Start()
    {

        StudentGrade = 5 + 8 - ((4 * 6) / 2);
        LittleNumber = 2 % 1; // LittleNumber = 0
        LittleNumber = 3 % 2; // LitleNumber = 1


        // Imprimir en la consola -- concatenación 
        //Debug.Log("El resultado de la operación de módulo es: " + LittleNumber);
        Debug.Log(LittleNumber + "1234"); 
        Debug.Log("El número más \"pequeño\" del mundo \n es: " + LittleNumber);





    }

    // Update is called once per frame
    void Update()
    {

        //StudentGrade = StudentGrade + 1;
        StudentGrade--;

        LittleNumber = 254;
        //Debug.Log(LittleNumber);

    }
}
