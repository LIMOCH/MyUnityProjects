using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }


}
