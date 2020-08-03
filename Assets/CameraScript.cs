
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //anim=GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(KeyCode.F)){
            transform.position=new Vector3(transform.position.x,0,transform.position.z);
        }
        
    }



    void OnTriggerExit(Collider other)
     {
       
        //anim.enabled=true;
 }

    void pauseAnimationEvent(){
        //anim.enabled=false;
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
        /*
        transform.position+=transform.forward*Time.deltaTime;
        */
    }
}
