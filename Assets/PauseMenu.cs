using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Ambas expresiones hacen lo mismo, pero requiere que devuelva algo y los botones no permiten funciones
            //que devuelvan algo
            //isPause = (isPause) ? Continue(): Pause();
            if (isPause)
            {
                Continue();
            }

            else
            {
                Pause();
            }

        }
    }

    public void Pause()
    {
        transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;
        //return true;
    }

    public void Continue()
    {
        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
        //return false;
    }

    public void CambiarEscena(string _newScene)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(_newScene);
        
    }
}
