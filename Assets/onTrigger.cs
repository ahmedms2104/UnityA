using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("coins"))
        {
            // Here you can do all sorts of cool stuff with the collected coin.
            // Like rotate it, activate particles, play audio, or just destroy it.

            // Destroys collected coin.
            Destroy(GetComponent<Collider>().gameObject);
        }
    }
}

