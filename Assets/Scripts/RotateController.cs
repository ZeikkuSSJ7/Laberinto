using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Quaternion.Euler(0, 0.1f, 0).eulerAngles);
    }
}
