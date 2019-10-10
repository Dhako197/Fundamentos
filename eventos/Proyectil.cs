using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField, Range(3, 10)] float duracion = 5;
    float time = 0;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= duracion)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision informacion)
    {
        GameObject objColisionado = informacion.gameObject;
        if (objColisionado.tag == "Jugador")
        {
            Salud a = objColisionado.GetComponent<Salud>();
            a.Golpeado(10);
        }

        if (objColisionado.tag == "Construccion")
        {
            SaludConst a = objColisionado.GetComponent<SaludConst>();
            a.Golpeado(5);
        }
    }
}
