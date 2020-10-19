using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float Speed = 1f;
    public float mouseSensitivity = 100f;
    private Camera MainCam;
    private Rigidbody rb;

    float xRotation = 0f;

    void Start()
    {
        MainCam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += transform.right * Speed * Input.GetAxis("Horizontal") * Time.deltaTime;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        MainCam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
