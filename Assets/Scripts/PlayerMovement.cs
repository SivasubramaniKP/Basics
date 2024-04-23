using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public float force = 1500f;
    public float sideforce = 500f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(force * Time.deltaTime,0,0);
        if( Input.GetKey("a")){
            rb.AddForce(0,0,sideforce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0,0,-sideforce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1.25f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
