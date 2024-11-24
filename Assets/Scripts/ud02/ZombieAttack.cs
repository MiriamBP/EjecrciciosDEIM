using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    //Eliminar objeto con tag Zombie
    private void OnTriggerEnter(Collider _infoAccess)
    {
        if(_infoAccess.CompareTag("Zombie"))
        {
            Destroy(_infoAccess.gameObject);
        }
    }
}
