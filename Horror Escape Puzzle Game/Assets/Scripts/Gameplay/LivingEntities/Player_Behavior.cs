using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour, IDeath
{



    public void Death()
    {
        Debug.Log("player death");
    }
}
