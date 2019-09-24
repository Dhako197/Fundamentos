using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimuladorViento : MonoBehaviour
{
    Rigidbody cambioDrag;
    

    // Start is called before the first frame update
    void Start()
    { 
        cambioDrag = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Pluma")
        {
            cambioDrag.drag = 10;
        }
        else if (tag == "Ladrillo")
        {
            cambioDrag.drag = 0;
        }
        else if(tag == "Papel")
        {
            cambioDrag.drag = 5;
        }

    }
}
