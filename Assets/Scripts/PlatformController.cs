using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float torque;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float turnX = Input.GetAxis("Horizontal");
        float turnY = Input.GetAxis("VerticalJ2");
        rb.AddTorque(Vector3.forward * torque * -turnX);
        rb.AddTorque(Vector3.right * torque * -turnY);
    }
}
