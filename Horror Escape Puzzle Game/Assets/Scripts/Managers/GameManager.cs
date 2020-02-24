using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    private bool isGamePaused = false;

    private void Awake()
    {
        if (!(instance is null) && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
    } //Singleton

    private void Start()
    {
        
    }

    private void OnDestroy()
    {
        instance = null;
    } 

    /// <summary>
    /// Check if game is currently paused.
    /// </summary>
    /// <return>
    /// Returns true or false.
    /// </return>>
    public bool IsGamePaused => isGamePaused;

    public void RespawnPlayer()
    {
        if(SaveLoadCheckpoint.GetLastCheckpoint != null)
        {
            SaveLoadCheckpoint.GetLastCheckpoint.gameObject.GetComponent<SaveLoadCheckpoint>().Respawn();
        }
    }

    /// <summary>
    /// Pauses the game.
    /// </summary>
    public void PauseGame() => Time.timeScale = 0f;
    public void ResumeGame() => Time.timeScale = 1f;
    public static GameManager GetInstance => instance;
}
