using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    //[SerializeField] private AudioMixer audio;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void ControlMaster()
    {
       //audio.SetFloat("volMaster", val);
    }

    public void ControlSFX()
    {
        //audio.SetFloat("volSFX", val);
    }

    public void ControlMusic()
    {
        //audio.SetFloat("volMusic", val);
    }

    public void ControlUI()
    {
        //audio.SetFloat("volUI", val);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
