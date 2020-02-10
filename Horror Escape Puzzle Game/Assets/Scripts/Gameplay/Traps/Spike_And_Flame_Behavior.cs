using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Spike_And_Flame_Behavior : MonoBehaviour
{

    private Animator popOut;

    private void Awake()
    {
        popOut = this.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!popOut.enabled) popOut.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player_Behavior>().Death();
        }
        else if (collision.gameObject.CompareTag("Monster"))
        {
            collision.gameObject.GetComponent<Monster_Behavior>().Death();
        }
    }
}
