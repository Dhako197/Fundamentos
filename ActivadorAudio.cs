using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAudio : MonoBehaviour
{

    AudioSource volumen;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        volumen = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t >= 5)
        {
            volumen.volume = 0;
        }

        
    }
}
