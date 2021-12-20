using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movee : MonoBehaviour
{
    [SerializeField] float mainFlying = 100;
    [SerializeField] float rotationFlying = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessFlying();
        ProcessRotation();
    }
    void ProcessFlying()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainFlying * Time.deltaTime);
        } 
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationFlying);
        }
    else if(Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationFlying);
        }
    }
    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
