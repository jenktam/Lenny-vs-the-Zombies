using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour 
{
    public Canvas MenuCanvas;
    public Canvas OptionsCanvas;

    void Awake()
    {
        OptionsCanvas.enabled = false;

    }

    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MenuCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MenuCanvas.enabled = true;
    }

    public void LoadOn()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
