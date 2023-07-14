using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WapointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; //array that can be changed from outside the scipt that can be infinitely large and hold the location of game objects inside
    int currentWaypointIndex = 0;//variable(int) called currentWaypointIndex this tells the script what waypoint in the array the script is currently using

    [SerializeField] float speed = 1f;//variable that can be changed from outside the script called speed

    void Update()//activates every single tick until the game is closed or stopped
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f) //checks to see if the parent of the script is within .1 studs of the waypoint it's heading to
        {
            currentWaypointIndex++;//increase the variable called currentwaypointindex by 1
            if (currentWaypointIndex >= waypoints.Length)//if currentwaypointindex number is larger than the amount of waypoints in the waypoints array
            {
                currentWaypointIndex = 0;//set the current waypoint index to 0
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);//creates a path to the current waypoint(decided by currentwaypointindex) and follows it.
    }
}
