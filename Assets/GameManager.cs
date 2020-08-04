
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {
        get {
            if(m_instance == null){
                m_instance = FindObjectOfType<GameManager>();
            }
            return m_instance;
        }
    }
    
    private static GameManager m_instance;
    
    public bool isGameover;
    


    public Dictionary<string, bool> items= new Dictionary<string, bool>();

    void Awake() {
        if(instance != this) {
            Destroy(gameObject);
        }
        else {
            items.Add("cellKey",true);
            items.Add("doorKey",true);
            items.Add("outKey",true);
            items.Add("shovel",true);
            items.Add("hammer",true);
            items.Add("cardKey",true);
            items.Add("bread",false);
            items.Add("meat",false);
            items.Add("cheese",false);
            items.Add("helicopter",false);

            isGameover = false;
        }
    }
}
