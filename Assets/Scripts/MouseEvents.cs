using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseevents : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Actuo cuando hago clic con el botón izquierdo del" +
                  " ratón sobre un objeto");
    }

    private void OnMouseUp()
    {
        Debug.Log("Actuo cuando dejo de hacer clic con el botón izquierdo" +
                  "del ratón");
    }

    private void OnMouseOver()
    {
        Debug.Log("Actuo cuando estoy sobre el collider");
    }

    private void OnMouseExit()
    {
        Debug.Log("Actuo cuando dejo de estar sobre el collider");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Actuo cuando arrastro el obejto");
    }
}
