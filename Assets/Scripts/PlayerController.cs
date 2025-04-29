using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
   // private Rigidbody rb;
    public GameObject LBulletPrefab;
    public GameObject RBulletPrefab;
    private float turnSpeed = 60f;

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
            Instantiate(LBulletPrefab, LBulletPrefab.transform.position, LBulletPrefab.transform.rotation);
            Instantiate(RBulletPrefab, RBulletPrefab.transform.position, RBulletPrefab.transform.rotation);
        }
        
       
        
        transform.Rotate(Vector3.forward * yInput * turnSpeed * Time.deltaTime);
        
    }

}
