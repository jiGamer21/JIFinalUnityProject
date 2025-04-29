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
        //float yInput = Input.GetAxis("Horizontal");

        //  rb.velocity = new Vector3(xInput, yInput, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoot
            Instantiate(bullets, bullets.transform.position, transform.rotation);
           //Instantiate(RBulletPrefab, RBulletPrefab.transform.position, RBulletPrefab.transform.rotation);
        }
        if (transform.position.y > -20 && transform.position.y < 20 | transform.position.x > -15 && transform.position.x < 15 |
          transform.position.z > -20 && transform.position.z < 15
         )
        { }
        else
        {
            Destroy(gameObject);
        }


        //transform.Rotate(Vector3.forward * yInput * turnSpeed * Time.deltaTime);
        //transform.RotateAround(playerTransform.position, Vector3.forward, turnSpeed * Time.deltaTime);
    }
   
}
