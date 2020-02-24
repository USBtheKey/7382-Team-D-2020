using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    private static int numLevelUnlocked;

    public static int NumLevelUnlocked { get => numLevelUnlocked;}

    //Here is a file that contains all the necessary data to the game.
    //i.e. saves, achievements, collections, etc...

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    private void Start()
    {
        LoadInitialData();
    }

    private void LoadInitialData()
    {
        numLevelUnlocked = PlayerPrefs.GetInt("NumLevelsUnlocked");
    }
}
