﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0);
    }
}
