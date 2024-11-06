using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coiins : MonoBehaviour
{

 public AudioSource coins;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coins.Play();
            Destroy(gameObject);
        }
    }















}
