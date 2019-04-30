using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIJuego : MonoBehaviour
{
    public Text texto;
    private int monedasActuales;
    private GameObject manager;
    private Manager managerScript;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        managerScript = manager.GetComponent<Manager>();
        monedasActuales = managerScript.contadorMonedas;
        texto.text = monedasActuales.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        monedasActuales = managerScript.contadorMonedas;
        texto.text = monedasActuales.ToString();
    }

    public void RecargarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
