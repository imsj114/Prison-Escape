
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Reference: https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time
// Use _preload scene as the starting (not destroyed throughout the scene).

public class GameManager : MonoBehaviour {
    private GameObject player;

    public enum Item
    {
        cellKey, doorKey, outKey, shovel, cardKey
    }

    public bool[] itemPicked = new bool[Enum.GetNames(typeof(Item)).Length];
    
    void Awake() {
        // player = GameObject.FindGameObjectsWithTag("Player")[0];
        // On awake, go to menu scene.
    }

    bool isGameOver = true;
    public void StartGame()
    {
        // Game started. Initialize all variables
        isGameOver = false;
        
        // Load the first scene in the game.
    }

    public void GameOver()
    {
        isGameOver = true;
        // Game is over!
    }

}