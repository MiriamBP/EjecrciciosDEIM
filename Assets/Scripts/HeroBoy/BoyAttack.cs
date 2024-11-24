using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAttack : MonoBehaviour
{
    //Zona de variables globales
    public GameObject Ball;
    public Transform PosRotBall;
    //fuerzas
    private float _thrustY = 100.0f,
                  _thrustZ = 300.0f,
                  _timeBall = 3.0f;

    // Update is called once per frame
    void Update()
    {
        CreateBalls();
    }

    private void CreateBalls()
    {
        if (Input.GetMouseButtonDown(0))
            {

            GameObject cloneBall = Instantiate(Ball, PosRotBall.position, PosRotBall.rotation);

            Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();

            rbBall.AddForce(Vector3.up * _thrustY);

            rbBall.AddForce(transform.forward * _thrustZ);

            Destroy(cloneBall, _timeBall);
        }
    }
}
