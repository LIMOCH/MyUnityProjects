using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

       SFPSC_PlayerMovement player = other.GetComponent<SFPSC_PlayerMovement>();

       //Количество монеток обновляется
       player.CollectCoins();

       //Монетка, которую собрали, уничтожается
       Destroy(gameObject);
    }

}
