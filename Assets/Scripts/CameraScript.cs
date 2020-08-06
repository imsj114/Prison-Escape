
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraScript : MonoBehaviour
{
    private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    //private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameManager.instance;
        Debug.Log("camera intersect");
        //anim=GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag != "Player") return;
        if(gameManager.items["isCCTVBroken"]) return;
        bool has_hammer = gameManager.items["hammer"];
        if (has_hammer){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "망치가 있으니 CCTV를 부수자.";
            return;
        }else{
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "이런... 저 CCTV 때문에 탈옥을 못하겠어! 과거로 가서 해결책을 찾자!";
            return;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag != "Player") return;
        bool has_hammer = gameManager.items["hammer"];
        
        if (has_hammer && Input.GetKeyDown(KeyCode.F)){
        transform.position=new Vector3(transform.position.x,0,transform.position.z);
        animator.SetBool("IsOpen", true);
        nameText.text = "나의 생각";
        dialogueText.text = "성공!";
        gameManager.items["isCCTVBroken"] = true;
        return;
        }
        
        
    }


    void OnTriggerExit(Collider other)
     {
       if (animator.GetBool("IsOpen") == true){
            animator.SetBool("IsOpen", false);
            return;
        }
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
