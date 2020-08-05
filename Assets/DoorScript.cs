﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public string keyName = "";
    private Animator anim;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        anim=GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        bool has_cellKey = (keyName != "") ? gameManager.items[keyName] : true;
        if (has_cellKey){
            if((other.tag == "Player" || other.tag == "Patrol") && anim.GetCurrentAnimatorStateInfo(0).IsName("Empty")){
                Vector3 doorToPlayer = other.transform.position - transform.position;
                float dotProduct = Vector3.Dot(transform.right, doorToPlayer);
                //Debug.Log(dotProduct.ToString());
                if(dotProduct > 0){
                    anim.SetTrigger("OpenDoorPos");
                }else{
                    anim.SetTrigger("OpenDoorNeg");
                }
                
            }
        }
    }

    void OnTriggerExit(Collider other)
     {
       
        anim.enabled=true;
 }

    // private bool IsOpenPanelActive
    // {
    //     get
    //     {
    //         return OpenPanel.activeInHierarchy;
    //     }
    // }

    // Update is called once per frame

    void pauseAnimationEvent(){
        anim.enabled=false;
    }
    void Update()
    {
        // if (IsOpenPanelActive)
        // {
        //     if (Input.GetKeyDown(KeyCode.E))
        //     {
        //         OpenPanel.SetActive(false);
        //         anim.SetBool("open", true);
        //     }
        // }
    }
}
