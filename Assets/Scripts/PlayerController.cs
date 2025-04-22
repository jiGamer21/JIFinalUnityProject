using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
   // private Rigidbody rb;
    public GameObject Projectiles;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");    
        
      //  rb.velocity = new Vector3(xInput, yInput, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoot
            Instantiate(Projectiles, transform.position, Projectiles.transform.rotation);
        }
        
    }
}
