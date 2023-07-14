using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //library allows the script to access the games UI 

public class ItemCollector : MonoBehaviour
{
    int coins = 0; //coins (number variable)
    [SerializeField] Text coinsText; //variable for a text box on the UI
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin")) //checks to see if an object has the tag "Coin"
        {

            Destroy(other.gameObject); //destroy the game object named coin
            coins++; //increases coins by 1
            coinsText.text = "Coins: " + coins; //Coins: 

        }

    }







}
