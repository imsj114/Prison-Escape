using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Push_True : MonoBehaviour
{
    public GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    void Start(){
        if (!gameManager.items["shovel"] ){
            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider _col)  //STAY
    {
        if (gameManager.items["shovel"] && Input.GetKeyDown(KeyCode.F) ){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "내가 이 곳을 파놨었지! 여기로 탈출해야겠다";
            transform.position=new Vector3(transform.position.x,transform.position.y, transform.position.z + 10f);
        }

        // if (Input.GetKeyDown(KeyCode.P)){
        // animator.SetBool("IsOpen", true);
        // nameText.text = "나의 생각";
        // dialogueText.text = "덮개를 덮어서 땅 판 흔적을 지워야겠다";
        // transform.position=new Vector3(transform.position.x,transform.position.y,-35.0f);
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
