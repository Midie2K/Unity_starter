using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    public GameObject[] waypoints;
    int wayPointIndex = 0;
    public float speed = 1f;
    void Update()
    {
        if(Vector3.Distance(transform.position,waypoints[wayPointIndex].transform.position) < 0.1f){
            wayPointIndex++;
            if(wayPointIndex >= waypoints.Length){
                wayPointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,waypoints[wayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
