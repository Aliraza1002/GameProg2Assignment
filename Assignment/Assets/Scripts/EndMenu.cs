using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void RestartGame()
    {
        GameManager.Instance.ResetGame();
        SceneManager.LoadScene(1);
    }
    public void OnGameStop()
    {
        Application.Quit();
    }
}


