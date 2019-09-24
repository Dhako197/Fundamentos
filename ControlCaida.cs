using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCaida : MonoBehaviour
{

    Rigidbody rBody;
    Renderer color;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        color = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(1, 0, 0);
        Debug.Log(rBody.velocity.y);

        if (rBody.velocity.y <= -20)
        {
            color.material.color = c;
        }

    }
}
