using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float Score = 0;
    public float currentScore;


    void Start()
    {
        currentScore = 0;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        } else
        {
            Instance = this;
        }
        DontDestroyOnLoad(Instance);
    }
    public void LevelCompleted()
    {
        currentScore = Score;
    }

    public void IncrementScore()
    {
        Score += 50;
    }
    public void ResetScore()
    {
        Score = currentScore;
    }

    public void ResetGame()
    {
        Score = 0;
        currentScore = 0;
    }
}
