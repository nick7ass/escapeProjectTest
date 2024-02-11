using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOnCollisionScript : MonoBehaviour
{
    public AudioSource audioPlayer;

    public void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "CollisionTag") // || collision.gameObject.tag == "BrickTag"
        {
            audioPlayer.Play();
        } 
    }
}
