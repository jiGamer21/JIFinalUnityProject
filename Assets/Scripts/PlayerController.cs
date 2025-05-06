using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;

    public float turnSpeed = 60f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        //  Q and E controll roll, a and d for yaw, w and s for pitch.
        
        float roll = Input.GetAxis("Roll");
        

        float pitch = Input.GetAxis("Pitch");

        float yaw = Input.GetAxis("Yaw");

            
        
      //  rb.velocity = new Vector3(xInput, yInput, speed * Time.deltaTime);
        
       
        //Roll:
        transform.Rotate(Vector3.forward * roll * turnSpeed * Time.deltaTime);

        //Pitch:
        transform.Rotate(Vector3.right * pitch * turnSpeed * Time.deltaTime);
       
        //Yaw:
        transform.Rotate (Vector3.up * yaw * turnSpeed * Time.deltaTime);



    }

    public float getTurnSpeed()
    {
        return turnSpeed;
    }

    //q and e to rotate on y
}
