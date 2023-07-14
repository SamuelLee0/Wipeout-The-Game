using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//library that allows for the script to manage scenes

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//when and object touches the finish object
    {
        if (other.gameObject.name == "Player")//if the object is called player
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//switch to the next scene by getting the current scene number using the build index.
        }



    }

}
