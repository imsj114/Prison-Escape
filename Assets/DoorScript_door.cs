
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript_door : MonoBehaviour
{
    private Animator anim;
    private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
         gameManager = GameManager.instance;
    }
    void OnTriggerStay(Collider other)
    {
        bool has_Key = gameManager.items["doorKey"];
        if (has_Key){
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
        }else{
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "열쇠가 없어서 들어갈 수가 없나봐..... 과거로 가서 열쇠를 찾아보자";
            return;
        
        }
    }

    void OnTriggerExit(Collider other)
     {
       
        anim.enabled=true;
        if (animator.GetBool("IsOpen") == true){
                animator.SetBool("IsOpen", false);
                return;
            }
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
