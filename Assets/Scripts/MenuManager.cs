using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    GameManager gameManager;
    void Awake()
    {
        gameManager = GameManager.instance;
    }

    public void StartGame()
    {
        gameManager.StartGame();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
