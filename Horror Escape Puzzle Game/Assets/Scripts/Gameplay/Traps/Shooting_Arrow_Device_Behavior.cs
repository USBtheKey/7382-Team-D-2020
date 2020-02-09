using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shooting_Arrow_Device_Behavior : MonoBehaviour
{

    public enum FiringMode { Automatic, Trigger, Burst, Random, Homing }

    [HideInInspector] private FiringMode firingMode;


    [Range(1f, 5f)]
    [SerializeField] private int burstShot;

    public FiringMode GetFiringMode => firingMode;

    public int carrot;

    // Start is called before the first frame update
    void Start()
    {
        switch (firingMode)
        {
            case FiringMode.Automatic:
                InvokeRepeating("Automatic", 0f, 1f);
                break;
            case FiringMode.Trigger:
                break;
            case FiringMode.Burst:
                
                break;
            case FiringMode.Random:
                
                break;
            case FiringMode.Homing:
                break;

        }
    }


    private void Automatic()
    {

    }
    private void Fire()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
