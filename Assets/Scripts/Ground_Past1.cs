using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ground_Past1 : MonoBehaviour
{

    private GameManager manager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;


    void Start(){
        manager = GameManager.instance;
        //manager.items["shovel"] = true;
    }

     void OnTriggerStay(Collider _col)  //STAY
    {
        if (!manager.items["shovel"]){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "여기 뭔가 땅굴을 팔 수 있을 것 같은데.. 삽을 찾아볼까?";
            return;
        }else{
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "아까 얻은 삽으로 땅굴을 파야겠다.";
            if(Input.GetKeyDown(KeyCode.F)){
                gameObject.SetActive(false);
                animator.SetBool("IsOpen", true);
                nameText.text = "나의 생각";
                dialogueText.text = "이 땅굴을 저 뚜껑으로 숨겨야지.";
                return;
            }
        
        }
        // if (Input.GetKeyDown(KeyCode.G) && manager.items["shovel"] ){
        //     animator.SetBool("IsOpen", true);
        //     nameText.text = "나의 생각";
        //     dialogueText.text = "삽으로 이곳을 파서 탈출해야지!";
        //     gameObject.SetActive(false);
        //     //portal 만들기
        // }
        // if(!(manager.items["shovel"]) ){
        //     animator.SetBool("IsOpen", true);
        //     nameText.text = "나의 생각";
        //     dialogueText.text = "여기 조금 파인 곳이 있다. 삽이 있으면 더 팔 수 있을 텐데";
        //     gameObject.SetActive(false);
        // }
    }

    void OnTriggerExit(Collider other)
     {
        if (animator.GetBool("IsOpen") == true){
            animator.SetBool("IsOpen", false);
            return;
            }
    }

}
