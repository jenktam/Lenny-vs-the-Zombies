using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{
    public Font LuckiestGuy { get; private set; }

    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.font = LuckiestGuy;
        myStyle.fontSize = 24;


        if (GUI.Button(new Rect((Screen.width / 2.0f) - 100, 
            (Screen.height / 2.0f) - 65, 250, 80), "Start Game", myStyle))
        {
            SceneManager.LoadScene("Level 01", LoadSceneMode.Single);
        }
        if (GUI.Button(new Rect((Screen.width / 2.0f) - 100, 
            (Screen.height / 2.0f) + 25, 250, 80), "Exit", myStyle))
        {
            Application.Quit();
        }
    }
}
