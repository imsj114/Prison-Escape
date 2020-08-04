
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;    

public class GameManager : MonoBehaviour {
    public static GameManager instance {
        get {
            if(m_instance == null){
                m_instance = FindObjectOfType<GameManager>();
            }
            return m_instance;
        }
    }
    
    private static GameManager m_instance;
    private GameObject player;
    private bool isGameOver = true;

    public Dictionary<string, bool> items= new Dictionary<string, bool>();
    

    string[] itemStrings =
        {
            "cellKey",
            "doorKey",
            "outKey",
            "shovel",
            "hammer",
            "cardKey",
            "bread",
            "meat",
            "cheese"
        };

    void Awake() {
        if(instance != this) {
            Destroy(gameObject);
        }
        else
        {
            foreach(string itemName in itemStrings){
            items.Add(itemName, false);
            }
            // TODO: Go to menu scene
        }
        
    }

    void Update() {
        if(Input.GetButtonDown("Cancel"))
            paused = togglePause();
    }

    public void StartGame()
    {
        isGameOver = false;
        foreach(string itemName in itemStrings){
            items[itemName] = false;
        }
        // TODO: Go to start scene
    }

    public void GameOver(bool escaped = false)
    {
        isGameOver = true;
        if(escaped) {
            // TODO: Player wins!
        } else {
            // TODO: Player loses
        }
    }

    private bool paused = false;
    private bool togglePause(){
        if(Time.timeScale == 0f) {
            Time.timeScale = 1f;
            // TODO: Popup pause menu
            return false;
        }
        else
        {
            Time.timeScale = 0f;
            // TODO: Remove pause menu
            return true;
        }
    }

}
