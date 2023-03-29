using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float sec = 2.0f;
    void Update()
    {
        sec += Time.deltaTime;
        print(sec);
    }
}
