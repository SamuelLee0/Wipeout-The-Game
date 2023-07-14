using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedX;//decimal variable that can be accessed from outside the script called speedX
    [SerializeField] float speedY;//decimal variable that can be accessed from outside the script called speedY
    [SerializeField] float speedZ;//decimal variable that can be accessed from outside the script called speedZ

    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);//equation to make the parent of the script rotate by their x y or z axis at a specified speed
    }
}
