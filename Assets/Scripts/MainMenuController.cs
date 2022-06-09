using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartButton()
    {
        Debug.Log("AR System is Loading...");
        SceneManager.LoadScene("SampleScene");
    }

    // StarterScene is called before the first frame update
    public void QuizButton()
    {
        Debug.Log("Quiz System is Loading...");
        SceneManager.LoadScene("StarterScene");
    }

    // StarterScene is called before the first frame update
    public void MainButton()
    {
        Debug.Log("Main menu is Loading...");
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void QuitButton()
    {
        Debug.LogError("AR System Stopped");
        Application.Quit();
    }
}
