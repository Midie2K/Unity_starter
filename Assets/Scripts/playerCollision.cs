using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public movemant movemant;
void OnCollisionEnter(Collision other) {
    if(other.collider.tag == "Obstacle"){
        movemant.enabled = false;

        FindObjectOfType<GameManager>().GameOver();
    }
    
 }
}
