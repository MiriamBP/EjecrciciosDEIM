using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider _infoAccess)
    {
        if (_infoAccess.CompareTag("AttackSword"))
        {
            Destroy(gameObject);
        }
    }
}
