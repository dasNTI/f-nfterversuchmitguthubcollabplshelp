using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraXRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        float v = 180 / Screen.height;
        transform.eulerAngles = new Vector3(
            mouse.y * v - 90,
            transform.eulerAngles.y,
            transform.eulerAngles.z
        );
    }
}
