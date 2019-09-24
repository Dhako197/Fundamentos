using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMasa : MonoBehaviour
{
    Rigidbody peso;
    Renderer color;
    float cambiocolor = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        peso = GetComponent<Rigidbody>();
        color = GetComponent<Renderer>();
        

       
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(1, 0, 0);
        cambiocolor = peso.mass;
        if (cambiocolor>= 5)
        {
            color.material.color = c;
        }


    }
}
