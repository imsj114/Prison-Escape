using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hellicopter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject helli;
    public GameObject ui;
    public GameObject follow;
    public GameObject fps;
     private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    //private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameManager.instance;
        
        //anim=GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        bool has_hammer = gameManager.items["helicopter"];

        if (has_hammer){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "F키를 눌러 헬리콥터를 호출해 이곳을 얼른 탈출하자!";
            if (Input.GetKeyDown(KeyCode.F)){
                Debug.Log("heli k pressed");
                fps.SetActive(false);
                helli.SetActive(true);
                ui.SetActive(true);
                follow.SetActive(true);
                animator.SetBool("IsOpen", false);
                return;
            }
        }
     else {
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "젠장... 이 산은 걸어서는 도저히 나갈수가 없겠는걸";

            
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
}
