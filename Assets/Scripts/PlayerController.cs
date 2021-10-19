using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 origin;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        origin = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal") * Vector3.right * 0.001f);
        rb.AddForce(Input.GetAxis("VerticalJ2") * Vector3.forward * -0.001f);
    }
}
