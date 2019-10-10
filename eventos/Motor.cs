using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float magnitud = 8;
    [SerializeField] float magAng = 90;
    [SerializeField] AudioClip idle;
    [SerializeField] AudioClip driving;
    [SerializeField] float  magFuerza = 500;
    float t = 0;
    float cooldown = 3;
   
    

    AudioSource sonido;
    Rigidbody cuerpo;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
        cuerpo = GetComponent<Rigidbody>();
        t = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = transform.forward;
        float sentido = Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * direccion * sentido;
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position = transform.position + distancia;
       
        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magAng * dirAng;
        Vector3 disAng = velAng * Time.deltaTime;
        transform.eulerAngles += disAng;

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            sonido.clip = driving;
            if (!sonido.isPlaying) sonido.Play();
        }
        else
        {
            sonido.clip = idle;
            if (!sonido.isPlaying) sonido.Play();
        }
        t += Time.deltaTime;
    }

    private void OnCollisionStay(Collision informacion)
    {
        float sentidoSalto = 1;
        Vector3 dir = transform.forward * 0.7f + transform.up * 0.3f;
        Vector3 salto = magFuerza * dir * sentidoSalto;
       

        if (Input.GetButtonDown("Jump") && t >= cooldown)
        {
            cuerpo.AddForce(salto);
            cuerpo.velocity = Vector3.zero;
            t = 0;
        }
    }

    
}
