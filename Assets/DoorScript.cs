
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");
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
