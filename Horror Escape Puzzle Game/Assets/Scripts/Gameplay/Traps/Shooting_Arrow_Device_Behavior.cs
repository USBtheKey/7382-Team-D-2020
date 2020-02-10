using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(BoxCollider2D))]
public class Shooting_Arrow_Device_Behavior : MonoBehaviour
{

    #region Fields
    [SerializeField] private GameObject projectile;

    //public enum FiringMode { Automatic, Trigger, Burst, Random, Homing }
    //[HideInInspector] private FiringMode firingMode;
    [HideInInspector][SerializeField] private int selectedFiringMode;
    
    //Invoke Repeating
    [HideInInspector][SerializeField] private float delay;
    [HideInInspector][SerializeField] private float repeatRate;

    [HideInInspector][SerializeField] private float burstDelay;

    [Range(1f,20f)]
    [SerializeField] private float arrowSpeed;
    #endregion

    #region Propreties
    //public FiringMode GetFiringMode => firingMode;
    public float Delay { get => delay; set => delay = value; }
    public float RepeatRate { get => repeatRate; set => repeatRate = value; }
    public int SelectedFiringMode { get => selectedFiringMode; set => selectedFiringMode = value; }
    public float BurstDelay { get => burstDelay; set => burstDelay = value; }
    #endregion

    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;


        switch (selectedFiringMode)
        {
            case 1: // Automatic
                InvokeRepeating("Fire", delay, repeatRate);
                break;

            case 2: // Trigger
                this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                break;

            case 3: // Burst
                //shoot 3 arrows in succession
                InvokeRepeating("Burst", delay, repeatRate);
                break;

            case 4: //Random
                InvokeRepeating("Fire", Random.Range(0f,5f), Random.Range(0f,5f));
                break;

            case 5: // Homing
                break;

        }
    }
    private void Burst()
    {

        InvokeRepeating("Fire", burstDelay, 1f);
   
    }

    private void Fire()
    {
        projectile.GetComponent<Arrow_Behavior>().ArrowSpeed = this.arrowSpeed;
        Instantiate(projectile, this.gameObject.transform);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When enter trigger shoot
        Fire();
    }

}
