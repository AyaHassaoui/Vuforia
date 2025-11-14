using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SlowRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; // degrees per second

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}