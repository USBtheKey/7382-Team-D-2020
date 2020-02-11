using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Last Checkpoint", SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLastCheckpoint()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Last Checkpoint"));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
