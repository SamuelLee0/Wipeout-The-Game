using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)//when an object is colliding with the object that's the scripts parent
    {
        if (collision.gameObject.name == "Player")//if the collision object is called "player"
        {
            collision.gameObject.transform.SetParent(transform);//make the "player" object the child of the script's parent
        }
    }

    private void OnCollisionExit(Collision collision)//when an object stops colliding with the object that's the scripts parent
    {
        if (collision.gameObject.name == "Player")//if the collision object is called "player"
        {
            collision.gameObject.transform.SetParent(null);//make the "player" object have no parent
        }
    }
}
