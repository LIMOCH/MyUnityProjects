using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    private bool isReady =true;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);

    }
    private void OnCollisionEnter(Collision other)
    {
        SFPSC_PlayerMovement player = other.gameObject.GetComponent<SFPSC_PlayerMovement>();
        player.TakeDamage(playerDamage);
    }
    private void OnCollisionStay(Collision other)
    {
        SFPSC_PlayerMovement player = other.gameObject.GetComponent<SFPSC_PlayerMovement>();
        if(isReady == true){
            StartCoroutine(reload(player));
            isReady = false;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        StopAllCoroutines();
    }
    IEnumerator reload(SFPSC_PlayerMovement player){
        yield return new WaitForSeconds(3);
        player.TakeDamage(playerDamage);
        isReady = true;
    }
}
