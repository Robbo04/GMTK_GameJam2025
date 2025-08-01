using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForScales : MonoBehaviour
{
    private float z;
    private bool rotateX;
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 0, z);
    }
}
