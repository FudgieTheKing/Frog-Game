using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject me;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward*speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destroy")
        {
            Destroy(me);
        }
    }
}
