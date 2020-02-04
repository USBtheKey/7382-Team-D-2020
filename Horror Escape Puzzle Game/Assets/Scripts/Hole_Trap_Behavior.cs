using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_Trap_Behavior : MonoBehaviour
{


    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.SetActive(false);

        if (collision.gameObject.CompareTag("Player")) collision.gameObject.GetComponent<Player_Behavior>().Death();
        else if(collision.gameObject.CompareTag("Monster")) collision.gameObject.GetComponent<Monster_Behavior>().Death();
    }
}
