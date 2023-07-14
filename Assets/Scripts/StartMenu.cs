using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//input a library called scene management which allows the script to edit the scenes

public class StartMenu : MonoBehaviour
{
    public void StartGame()//function called startgame
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//when activated switch to the next scene
    }
}

//this script is for a button on the start menu