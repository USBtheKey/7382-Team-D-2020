using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent( typeof(BoxCollider2D))]
public class Platform_Behavior : MonoBehaviour
{

    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed;
    [SerializeField] private float stopTime;


    private Rigidbody2D platRigid;
    private Collider2D platColl;

    // Start is called before the first frame update
    void Start()
    {
        platColl = this.gameObject.GetComponent<BoxCollider2D>();
        //platRigid = this.gameObject.GetComponent<Rigidbody2D>();

        this.gameObject.transform.position = waypoints[0].position;

        MovePlatform();
    }

    private void MovePlatform()
    {
        while (true)
        {
            for (int i = 0; i < waypoints.Length; i++)
            {
                Vector2 direction = (waypoints[i].position - this.gameObject.transform.position).normalized;
                gameObject.transform.Translate(direction * speed * Time.deltaTime);
                Debug.Log(i);
            }

            for (int i = waypoints.Length; i > 0; i--)
            {
                //Vector2 direction = (waypoints[i].position - this.gameObject.transform.position).normalized;
                //gameObject.transform.Translate(waypoints[i].position * speed * Time.deltaTime);
            }
        }
        
    }
    
}
