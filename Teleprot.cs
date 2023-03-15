using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleprot : MonoBehaviour
{
    public Transform teleportPoint;
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(3.6f, 4.4f, 12.9f);
    }
}
