using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnePlayerGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void MainMenuGame(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void RetryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
