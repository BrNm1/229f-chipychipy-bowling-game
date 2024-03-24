using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("Button clicked!");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); 
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");   
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked!");
        Application.Quit(); 
    }
}
