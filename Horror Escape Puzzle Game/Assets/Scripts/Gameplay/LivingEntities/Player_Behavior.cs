using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_Behavior : MonoBehaviour, IDeath
{
    public UnityEvent OnDeath;

    private GameMenuManager gmm;

    private void Awake()
    {
        gmm = GameMenuManager.GetInstance;
    }

    private void Start()
    {
        OnDeath.AddListener(gmm.OnPlayerDeath);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Ground")) Death();
    }

    public void Death()
    {
        Debug.Log("player death");
        //if only collision with spikes - gets stuck at that position and piss blood
        //if trigger enter on fire/lava/laser - gets fried to a crisp
        //if bomb vest explodes - blood flies everywhere + screen shake?
        Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        //this.gameObject.transform.Find("Main Camera").parent = null;
        OnDeath.Invoke();
    }
}
