using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up*speed);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.tag == "asteroide")
        {
            collision.gameObject.GetComponent<asteroidcontroler>().Muerte();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
