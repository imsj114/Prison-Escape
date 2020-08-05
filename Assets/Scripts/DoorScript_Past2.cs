
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript_Past2 : MonoBehaviour
{
    private Animator anim;
    private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameManager.instance;
        anim=GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        bool has_cellKey = gameManager.items["doorKey"];
        if (has_cellKey){
            if((other.tag == "Player" || other.tag == "Patrol") && anim.GetCurrentAnimatorStateInfo(0).IsName("Empty")){
                animator.SetBool("IsOpen", true);
                nameText.text = "나의 생각";
                dialogueText.text = "밖에 경비원이 있으니 조심해야겠어!";
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
            dialogueText.text = "열쇠가 없어서 들어갈 수가 없나봐..... 열쇠를 찾아보자";
            return;
        
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
