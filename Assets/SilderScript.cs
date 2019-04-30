using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilderScript : MonoBehaviour
{

    //Referencia https://www.youtube.com/watch?v=QZDw8ycoLRw
    private AudioSource audiSrc;

    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audiSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audiSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
