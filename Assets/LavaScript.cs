using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject manager;
    public Manager managerScript;

    public AudioClip SoundToPlayGameOver;
    
    private AudioSource audioSrc;
    void Start()
    {
        //Hago referencia al GameObject Manager y a su Script
        manager = GameObject.Find("Manager");
        managerScript = manager.GetComponent<Manager>();

        //ContMonedas = 0;

        audioSrc = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Solo se necesita 1 power up para sobrevivir la lava
        if (other.gameObject.tag == "Pelota" && managerScript.contadorMonedas < 1)
        {
            Debug.Log("Se ha destruido la pelota");
            audioSrc.PlayOneShot(SoundToPlayGameOver, 1f);

 
        }
    }
}
