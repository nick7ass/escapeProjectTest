using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollisionScript : MonoBehaviour
{
    private int doorLife = 5;
    public AudioSource audioSource;
    //public GameObject lightSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BrickTag" && doorLife >=1)
        {
            doorLife -= 1;
            audioSource.Play();
        } else
        {
            audioSource.Play();
            gameObject.SetActive(false);
            //lightSource.SetActive(true);
        }
    }
}
