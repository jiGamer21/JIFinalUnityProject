using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
   // private Rigidbody rb;
   // public GameObject LBulletPrefab;
    //public GameObject RBulletPrefab;
    public float turnSpeed = 60f;


    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //In one of the early create with code challenges, the plane one where you fly through holes in walls, there’s a line where you rotate the plane- it’s 
        // based on left/right, forward/backward, and up/down. I just applied different ones for how I wanted the plane to move and assigned them to different buttons.
        //  Q and E controlled roll, a and d for yaw, w and s for pitch.
        
        float roll = Input.GetAxis("Roll");
        // float rollLeft = Input.GetKeyDown(KeyCode.Q);

        float pitch = Input.GetAxis("Pitch");
        // float pitchDown = Input.GetKeyDown(KeyCode.S);

        float yaw = Input.GetAxis("Yaw");
        // float yawRight = Input.GetKeyDown(KeyCode.D);

            
        
      //  rb.velocity = new Vector3(xInput, yInput, speed * Time.deltaTime);
        
       
        //Roll:
        //Left
        transform.Rotate(Vector3.forward * roll * turnSpeed * Time.deltaTime);
        //right
        // transform.Rotate(Vector3.back * rollLeft * turnSpeed * Time.deltaTime);

        //Pitch:
        //Up
        transform.Rotate(Vector3.right * pitch * turnSpeed * Time.deltaTime);
        //Down
        // transform.Rotate(Vector3.down * pitchDown * turnSpeed *Time.deltaTime);

        //Yaw:
        //Left
        transform.Rotate (Vector3.up * yaw * turnSpeed * Time.deltaTime);
        //Right


    }

    public float getTurnSpeed()
    {
        return turnSpeed;
    }

    //q and e to rotate on y
}
