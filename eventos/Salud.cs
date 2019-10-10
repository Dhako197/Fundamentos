using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{

    public float salud = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (salud == 0) Destroy(gameObject);
        
    }
    public void Golpeado(float _cantidad)
    {
        salud -= _cantidad;

    }
}
