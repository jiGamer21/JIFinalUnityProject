using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 50f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > 20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > 20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < 0)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > 295)
        {
            Destroy(gameObject);
        }
    }

}
