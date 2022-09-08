using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocity = 25;
    public Rigidbody Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody.velocity = transform.forward * velocity;
        Rigidbody.AddForce(transform.forward * velocity, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
