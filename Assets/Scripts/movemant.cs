using UnityEngine;

public class movemant : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 200f;
    public float sideForce = 500f;
    void FixedUpdate(){
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideForce * Time.deltaTime, 0 ,0 , ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime, 0 ,0 , ForceMode.VelocityChange);
        }

        if(rb.position.y < - 1){
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
