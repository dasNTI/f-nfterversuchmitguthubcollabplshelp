﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    
    public float Speed = 10f;
    public float TurnSpeed = 2f;
    public Rigidbody rb;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += transform.forward * Speed * Mathf.Round(Input.GetAxis("Vertical")) * Time.deltaTime;
        transform.Rotate(0, Input.GetAxis("Mouse X") * TurnSpeed, 0);
    }
}
