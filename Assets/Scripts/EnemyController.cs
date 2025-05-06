using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private GameObject player;
    private Rigidbody enemyRb;
    private GameManager gameManager;
   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PLANE");
        enemyRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find ("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetAttack = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(targetAttack * speed);

        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullets"))
        {
            // gameManager.UpdateScore(+3);
            // Destroy(other.gameObject);
            Destroy(gameObject);
            gameManager.UpdateScore(5);
            
        }
    }
}