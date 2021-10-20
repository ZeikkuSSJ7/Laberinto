using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float torque;
    private Rigidbody rb;
    private Quaternion rotation;
    private Quaternion rotMax = Quaternion.Euler(30, 30, 30);
    private Quaternion rotMin = Quaternion.Euler(-30, -30, -30);
    private float turnX;
    private float turnY;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        turnX = Input.GetAxis("Horizontal");
        turnY = Input.GetAxis("VerticalJ2");

        rotation = transform.rotation;
        if (canRotateZ())
            rb.AddTorque(Vector3.forward * torque * -turnX);
        if (canRotateX())
            rb.AddTorque(Vector3.right * torque * -turnY);
        transform.rotation = rotation;
    }

    private bool canRotateZ()
    {
        if (rotation.z < -0.21 && turnX > 0)
        {
            return false;
        }
        else if (rotation.z > 0.21 && turnX < 0)
        {
            return false;
        }
        else
            return true;
    }

    private bool canRotateX()
    {
        if (rotation.x < -0.21 && turnY > 0)
        {
            return false;
        }
        else if (rotation.x > 0.21 && turnY < 0)
        {
            return false;
        }
        else
            return true;
    }
}
