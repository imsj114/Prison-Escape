
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
    private GameObject pauseSceneRoot;

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
            "cheese",
            "helicopter"
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
            SceneManager.LoadScene("Menu");
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
        }
        
    }

    void Start() 
    {
        pauseSceneRoot = GameObject.FindWithTag("PauseMenu");
        pauseSceneRoot.SetActive(false);
        DontDestroyOnLoad(pauseSceneRoot);
    }

    void Update() {
        if(Input.GetButtonDown("Cancel") && !isGameOver)
            SetPauseMenu();
    }

    public void SetPauseMenu() {
        paused = togglePause();
        pauseSceneRoot.SetActive(paused);
    }

    public void StartGame()
    {
        isGameOver = false;
        foreach(string itemName in itemStrings){
            items[itemName] = false;
        }
        // TODO: Go to start scene
        Initiate.Fade("Past2",Color.black,1f);
        //SceneManager.LoadScene("Present");
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

    public void GoToMenu()
    {
        return;
    }

    public bool paused = false;
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
