using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    
    public float xmov = 0;
    public float zmov = 0;
    public float Speed = 0.1f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + xmov * Time.deltaTime, transform.position.y, transform.position.z + zmov * Time.deltaTime);
        xmov = 0;
        zmov = 0;
        if (Input.GetKey(KeyCode.S))
        {
            xmov = Mathf.Sin((transform.eulerAngles.y + 180) % 360) * Speed;
        }

        if (Input.GetKey(KeyCode.T)) 
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);
        }

        if (transform.eulerAngles.y <= 0) transform.eulerAngles = new Vector3(transform.eulerAngles.x, 360, transform.eulerAngles.z);
    }
}
