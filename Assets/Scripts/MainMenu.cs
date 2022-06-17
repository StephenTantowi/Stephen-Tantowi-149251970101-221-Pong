using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Stephen Tantowi - 149251970101-221");
    }
    public void Author()
    {
        Debug.Log("Created by Stephen Tantowi - 149251970101-221");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }    
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
}
