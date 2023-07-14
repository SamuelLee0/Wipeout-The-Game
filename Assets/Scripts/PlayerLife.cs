using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//uses a library that allows the script to manage scenes

public class PlayerLife : MonoBehaviour
{

    private void Update()//update functuon (runs code inside once every tick)
    {

        if (transform.position.y < -0.1f)//if the parent of this script is below y 0
        {
            Die();//call the die function
        }

    }

    private void OnCollisionEnter(Collision collision)//every time the player collides with an object call this function
    {

        if(collision.gameObject.CompareTag("Enemy Body"))//if the object has the tag "Enemy Body"
        {
            Die();//call the die function
        }


    }

    void Die()//function called die
    {

        GetComponent<MeshRenderer>().enabled = false;//toggle the player mesh(hides the player)
        GetComponent<PlayerMovement>().enabled = false;//toggle the player controls(off)
        Invoke(nameof(ReloadLevel), .1f);//calls the reloadlevel function after one tenth of a second

    }

    void ReloadLevel()//function called reloadlevel
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//takes the player back to the begining of the level and resets everything

    }






}
