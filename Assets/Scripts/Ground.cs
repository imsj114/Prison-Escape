using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    public GameManager manager;
     void OnTriggerStay(Collider _col)  //STAY
    {

        Debug.Log("Collide");
    
        if (Input.GetKeyDown(KeyCode.G) && manager.items["shovel"] ){
           gameObject.SetActive(false);
        }
        if( Input.GetKeyDown(KeyCode.G) && !(manager.items["shovel"]) ){
            Debug.Log("You do not have a shovel");
        }
    }

}
