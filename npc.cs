using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    private int health = 5;
    private int level = 1;
    private int speed = 10;

    void Start()
    {
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
        health += level;
    }
}
