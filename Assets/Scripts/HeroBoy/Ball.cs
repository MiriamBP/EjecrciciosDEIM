using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Zona de variables globales
    public Material Mat;


    /*private void OnCollisionEnter(Collision infoCollision)
    {
        Debug.Log("He chocao con " + infoCollision.gameObject.name);

        //comprobar si estoy chocando con el cubo
        //Acceder al collider del objeto con el que está chocando la bola
        //Ver si su etiqueta es Enemy

        if (infoCollision.collider.CompareTag("Enemy"))
        {
            //Cambiar material del cubo
            //Acceder a su componente renderer y asu propiedad Material
            infoCollision.gameObject.GetComponent<Renderer>().material = Mat;
        }
    }*/

    private void OnCollisionrEnter(Collision infoAccess)
    {
        Debug.Log("Estoy haciendo una colisión trigger con " + infoAccess.gameObject.name);
        //identificar contra que estoy chocando
        if (infoAccess.collider.CompareTag("Enemy"))
        {
            //gameObject hace referencia al cubo
            Destroy(infoAccess.gameObject);
        }
    }
}
