using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource button ;

    public void PlaySound()
    {
        button.Play();
    }

}
