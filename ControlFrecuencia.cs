using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFrecuencia : MonoBehaviour
{
    AudioSource control;
    Light luz;
    float intensidad = 0;

    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
        control = GetComponent<AudioSource>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        intensidad = luz.intensity;
        if (intensidad < 0.5)
        {
            control.pitch = 0.5f;
        }
    }
}
