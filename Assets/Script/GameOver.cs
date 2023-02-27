using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOverActive()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void Load()
    {
        SceneManager.LoadScene(0);
    }
}
