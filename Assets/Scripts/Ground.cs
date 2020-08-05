using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour
{

    public GameManager manager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    void Start(){
        manager = GameManager.instance;

        if (manager.items["shovel"]){
            gameObject.SetActive(false);
        }
    }

     void OnTriggerStay(Collider _col)  //STAY
    {
        if (!manager.items["shovel"]){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "나갈 길이 없어.. 과거로 돌아가 땅굴을 파야겠다";
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
