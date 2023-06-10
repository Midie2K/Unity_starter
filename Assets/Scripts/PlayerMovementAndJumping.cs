using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementAndJumping : MonoBehaviour
{
    Rigidbody rb;
    public float force = 1f;
    public float jumpForce = 1f;
    public GameManager gm;
     public Transform groundCheck;

    public LayerMask ground;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate(){

        rb.freezeRotation=true;
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontal * force * Time.deltaTime, rb.velocity.y, vertical * force * Time.deltaTime);

        if(Input.GetKey("space") && CheckGround()){
            Jump();
        }

        if(rb.position.y < -0.5){
            gm.GameOver();
        }

    }
     void Jump(){
        rb.velocity = new Vector3(0,5,0) * Time.deltaTime * jumpForce;
     }
    
    bool CheckGround(){
         return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("EnemyHead")){
            Destroy(other.transform.parent.gameObject);
            Jump();
        }
    }
}


