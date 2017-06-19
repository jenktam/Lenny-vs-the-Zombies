using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnGoalEnter : MonoBehaviour {

    public Text wonLevelText;
    public Text goalText;
    public Canvas nextLevelCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            goalText.text = "";
            wonLevelText.text = "Lenny was able to run away from the zombies this time. Lenny runs to the castle to warn the rest of his town before it's too late!";
            //Destroy(other.gameObject);
            //StartCoroutine(LoadLevel("test", 10.0f));
            LoadNextLevel();
        }
    }

    //IEnumerator LoadLevel(string level, float waitTime)
    //{
    //    yield return new WaitForSeconds(waitTime);
    //    Application.LoadLevel("Level02");
    //}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
