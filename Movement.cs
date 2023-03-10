using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
