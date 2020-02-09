using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Behavior : MonoBehaviour
{

    [Range(1, 20)]
    [SerializeField] private int arrowSpeed;

    

    private void Awake()
    {

    }


    private void FixedUpdate()
    {
        
        this.gameObject.transform.Translate(Vector2.up * arrowSpeed * Time.deltaTime); // Make the arrow move forward
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = this.gameObject.transform;
        }
    }
}
