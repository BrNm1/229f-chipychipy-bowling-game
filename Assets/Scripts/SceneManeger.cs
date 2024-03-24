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
        SceneManager.LoadScene("Menu"); // โหลดซีนหน้าเมนูตอนคลิกปุ่มกลับไปหน้าเมนู
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");   //หน้าเครดิต
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked!");
        Application.Quit(); 
    }
}
