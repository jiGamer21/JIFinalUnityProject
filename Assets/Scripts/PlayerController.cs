using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");    
        
        rb.velocity = new Vector3(xInput, yInput, speed * Time.deltaTime);
        /*float forwardForce = Time.deltaTime * speed * xInput;
        float sidewaysForce = Time.deltaTime * speed * yInput;
*/
        
    }
}
