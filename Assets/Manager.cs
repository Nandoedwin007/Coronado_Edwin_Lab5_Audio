using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject player;
    public GameObject currPlayer;


    //Quité el contador de monedas de la clase Esfera y lo hice en la clase Manager porque al momento de usar un 
    //Pelota(Clone) no funcionaba la UI, ahora en el Manager es un contador GLOBAL
    public int contadorMonedas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (player && !currPlayer)
            {
                currPlayer = Instantiate(player, new Vector3(7.4f, 5, -7.8f), Quaternion.identity);
                currPlayer.tag = "Pelota";
                
            }
        }
    }
}
