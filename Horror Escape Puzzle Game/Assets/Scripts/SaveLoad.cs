using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour
{
    private Transform lastCheckpoint;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Waypoint")
        {
            lastCheckpoint = collision.transform;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetString("Last Checkpoint", SceneManager.GetActiveScene().name);
    }

    public void LoadLastCheckpoint()
    {
        //SceneManager.LoadScene(PlayerPrefs.GetString("Last Checkpoint"));
        Instantiate(Player, lastCheckpoint.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
