using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOnScript : MonoBehaviour
{
    public GameObject lightSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void turnOnLightSource()
    {
        lightSource.SetActive(true);
    }
}
