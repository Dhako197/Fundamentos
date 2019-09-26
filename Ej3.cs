using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{

    Light luz;
    // Start is called before the first frame update
    void Start()
    {

        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Color a = new Color(1, 0, 0);
        Color b = new Color(0, 0.63f, 0.90f);
        Color c = new Color(1, 1, 1);

        if (luz.intensity > 0.25 && luz.intensity < 0.5) luz.color = b;
        else if (luz.intensity > 0.5 && luz.intensity < 0.75) luz.color = a;
        else if (luz.intensity >= 0.75) luz.color = c;
    }
}
