using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class prjectile : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmmount = 15.0f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        Vector3 ForceDirection= transform.forward;
        rigidbody.AddForce(force: ForceDirection * forceAmmount, ForceMode.VelocityChange);   
    }
    void OnCollisionEnter(Collision other)
    {
        print("collides with " + other.gameObject.name);
        if (other.gameObject.CompareTag("castle"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
}
}