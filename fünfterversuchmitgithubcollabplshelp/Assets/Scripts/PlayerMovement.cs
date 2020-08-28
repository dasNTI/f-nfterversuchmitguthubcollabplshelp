using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    
    private float xmov = 0;
    private float zmov = 0;
    public float Speed = 0.1f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + xmov * Time.deltaTime, transform.position.y, transform.position.z + zmov * Time.deltaTime);
        xmov = 0;
        zmov = 0;
        if (Input.GetKey(KeyCode.S))
        {
            xmov = Mathf.Sin(Mathf.Abs(transform.eulerAngles.y)) * Speed;
            zmov = Mathf.Sqrt(Speed*Speed - xmov*xmov);
        }

        if (Input.GetKey(KeyCode.T)) 
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);
        }
    }
}
