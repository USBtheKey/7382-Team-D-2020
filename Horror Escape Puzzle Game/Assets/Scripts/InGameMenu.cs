using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InGameMenu : MonoBehaviour
{
    private static InGameMenu instance = null;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject deathScreen;
    private GameManager gm;
    

    private void Awake()
    {
        if (!(instance is null) && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
    } // Singleton

    void Start()
    {
        pauseMenu.SetActive(false);
        gm = GameManager.GetInstance;
    }


    void Update()
    {

    }

    private void OnEscapeToggle(InputAction.CallbackContext context)
    {
        if (context.performed && gm.IsGamePaused)
        {
            gm.PauseGame();
            pauseMenu.SetActive(true);
        }
        else
        {

        }
    }

    



    private void OnDestroy()
    {
        instance = null;
    }

    public static InGameMenu GetInstance => instance;
}
