using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.CompareTag("enemy")){
            Die();
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void Die(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovementAndJumping>().enabled = false;
    }
}
