﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the next level in the game if pressed on play
    }


    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); //Quits the game
    }
}
