using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    // private Rigidbody rb;
    public GameObject bullets;
    private GameObject player;
    private float turnSpeed = 60f;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        player = GameObject.Find("PLANE");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y > -20 && transform.position.y < 20 | transform.position.x > -15 && transform.position.x < 15 |
          transform.position.z > -20 && transform.position.z < 15)
        {
            if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoot
            Instantiate(bullets, bullets.transform.position, transform.rotation);
           
        }
        }
        
        else
        {
            //Destroys out of bounds bullets
            Destroy(gameObject);
        }
    }
   
}
