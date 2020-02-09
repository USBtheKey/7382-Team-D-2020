﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_And_Flame_Behavior : MonoBehaviour
{


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
