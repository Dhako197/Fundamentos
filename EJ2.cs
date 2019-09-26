using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Renderer render;
    float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Color a = new Color(1, 0, 0);
        Color b = new Color(0, 0.63f, 0.90f);
        Color c = new Color(0.25f, 0, 0.50f);

        if (t < 3) render.material.color = a;
        else if (t >= 3 && t < 6) render.material.color = b;
        else render.material.color = c;

    }
}
