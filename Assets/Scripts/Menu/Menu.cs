using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour 
{
    public Canvas MenuCanvas;
    public Canvas OptionsCanvas;

    private bool _isMuted = false;

    void Awake()
    {
        OptionsCanvas.enabled = false;

    }
    //Options Section
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MenuCanvas.enabled = false;
    }

    // Use this for initialization
    public void ToggleSound()
    {
        _isMuted = !_isMuted; // inverts the value. false -> true. true -> false
        AudioListener.volume = _isMuted ? 1f : 0f; // ? operator allows you to assing values depending on a boolean expression (expression?true:false;)
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MenuCanvas.enabled = true;
    }

    //Menu Section
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
