using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerControlScript : MonoBehaviour
{
    //private Animator crawlerAnim;
    private Rigidbody crawlerRig;
    public int crawlerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //crawlerAnim = GetComponent<Animator>();
        crawlerRig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        crawlerRig.AddForce(Vector3.forward * crawlerSpeed * Time.deltaTime, ForceMode.Force);
    }
}
