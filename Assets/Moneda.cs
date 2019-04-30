using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // Start is called before the first frame update
    //Referencia https://www.youtube.com/watch?v=QZDw8ycoLRw

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * 100, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        //Las monedas se destruyen al tocar la pelota para que sea propiedad de la moneda y no pelota
        if (other.gameObject.tag == "Pelota")
        {
            
            Destroy(gameObject);
        }
    }

}
