using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Clicked Play Game");
        SceneManager.LoadScene("Level0");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void OpenShop()
    {
        Debug.Log("Clicked Shop");
    }
}
