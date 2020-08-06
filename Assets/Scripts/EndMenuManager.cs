using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuManager : MonoBehaviour
{
    GameManager gameManager;
    void Awake()
    {
        gameManager = GameManager.instance;
    }

    public void Restart()
    {
        gameManager.StartGame();
    }

    public void GoToMenu()
    {
        gameManager.GoToMenu();
    }
}
