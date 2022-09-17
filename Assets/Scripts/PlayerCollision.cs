using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float mass;
    public Rigidbody rb;

    void Start()
    {

    rb = GetComponent<Rigidbody>();
    mass = rb.mass;
        
    }

 void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);

        if (collision.gameObject.tag == "edible"){
            Rigidbody edibleRb = collision.gameObject.GetComponent<Rigidbody>();
            float edibleMass = edibleRb.mass;

            Destroy(collision.gameObject);

            gameObject.transform.localScale += new Vector3(mass, mass, mass);
        }
    }
}
