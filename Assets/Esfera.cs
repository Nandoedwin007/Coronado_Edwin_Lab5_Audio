using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{

    

    private Rigidbody rb;

    public GameObject manager;
    public Manager managerScript;

    public AudioClip SoundToPlayPower;
    //public AudioClip SoundToPlayGameOver;

    public AudioClip SoundToPlayLinkStarto;
    public AudioClip SoundToPlayOof;
    public AudioClip SoundToPlayWhoa;

    private bool whoaPlayed = false;


    private AudioSource audioSrc;

    //Quité el contador de monedas de esta clase y lo hice en la clase Manager porque al momento de usar un 
    //Pelota(Clone) no funcionaba la UI, ahora en el Manager es  un contador GLOBAL
    //public int ContMonedas;

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Hago referencia al GameObject Manager y a su Script
        manager = GameObject.Find("Manager");
        managerScript = manager.GetComponent<Manager>();

        //ContMonedas = 0;

        audioSrc = GetComponent<AudioSource>();

        audioSrc.PlayOneShot(SoundToPlayLinkStarto, 1f);
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Vertical") * force, 0, Input.GetAxis("Horizontal") * force);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        //Solo se necesita 2 power up para sobrevivir la lava
        if (managerScript.contadorMonedas >= 2 && whoaPlayed == false)
        {
            audioSrc.PlayOneShot(SoundToPlayWhoa, 1f);
            whoaPlayed = true;
        }

    }


    private void OnTriggerEnter(Collider other)
    {

        //Las monedas se destruyen en el script Moneda, para que sea propiedad de la moneda y no pelota
        if (other.gameObject.tag == "Moneda")
        {
            //En el Laboratorio 2
            //ContMonedas += 1;

            //Laboratorio 3 para variable Global
            managerScript.contadorMonedas += 1;
            audioSrc.PlayOneShot(SoundToPlayPower, 1f);
        }

        //Solo se necesita 2 power up para sobrevivir la lava
        if (other.gameObject.tag == "Lava" && managerScript.contadorMonedas < 2)
        {
                 Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Solo se necesita 1 power up para sobrevivir la lava
        if (collision.gameObject.tag == "Pared")
        {
            audioSrc.PlayOneShot(SoundToPlayOof, 1f);
            //Destroy(gameObject);
        }
    }
    //Esto salta
    private void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.005f)
        {
            rb.AddForce(0, 2*force, 0, ForceMode.Impulse);
        }
    }

    
}
