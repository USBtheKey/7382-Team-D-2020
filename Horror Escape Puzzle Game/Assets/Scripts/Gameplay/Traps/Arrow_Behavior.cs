using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Arrow_Behavior : MonoBehaviour
{
    [HideInInspector][SerializeField] private float arrowSpeed;

    public float ArrowSpeed { set => arrowSpeed = value; }


    private void FixedUpdate()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * this.arrowSpeed * 100 * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT!");
            collision.gameObject.transform.parent = this.gameObject.transform;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT!");
            collision.gameObject.transform.parent = this.gameObject.transform;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody2D>().mass = 0f;
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = this.gameObject.GetComponent<Rigidbody2D>().velocity;
            //collision.gameObject.GetComponent<Transform>().position = this.transform.position;
        }
    }
}
