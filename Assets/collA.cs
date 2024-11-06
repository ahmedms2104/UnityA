using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collA : MonoBehaviour
{

    public float stepBack = 2.0f;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 stepBackDirection = -collision.contacts[0].normal*stepBack;
            collision.rigidbody.AddForce(stepBackDirection);
        }
    }
    // Start is called before the first frame update
    
}
