using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogCollider : MonoBehaviour
{
    GameManager gameManager;
    public string stageName;
    
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    private void Awake() {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag != "Player") return;
        int stage = gameManager.stages[stageName];
        animator.SetBool("IsOpen", true);
        nameText.text = "나의 생각";
        if(stageName == "present"){
            switch(stage) {
            case 0:
                dialogueText.text = "으... 빨리 이 지겨운 감옥에서 탈출해야겠어.\n어? 왜 옷장이 열려있지?";
                break;
            case 1:
                dialogueText.text = "다시 현재로 돌아왔어. 이제 탈출해볼까?";
                break;
            }    
        }
        if(stageName == "past1" && !gameManager.items["groundDigged"]){
            dialogueText.text = "오잉? 여긴 어디지? 교도소가 아직 공사중인 것 같은데?\n밖으로 나가서 탐방해보자.";
        }
        if(stageName == "past2" && !gameManager.items["cardKey"]){
             dialogueText.text = "또 어딘가로 온건가..... 공사는 끝난 것 같군.";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag != "Player") return;
        if (animator.GetBool("IsOpen") == true){
                animator.SetBool("IsOpen", false);
                return;
        }
    }
}
