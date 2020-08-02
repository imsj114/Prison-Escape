using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
​
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
    
    public bool isGameover { get; private set; }
    private static GameManager m_instance;
    

    private Player player1;
    public boolean digged=false;


    public Item cellKey, doorKey, outKey, shovel,cardKey;

    public Movable patrol;
    
    void Awake() {
        if(instance != this) {
            Destroy(gameObject);
        }else {
            player1 = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>();
            isGameover = false;
        }
    }


}