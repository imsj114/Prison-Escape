using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Push_Past1 : MonoBehaviour
{
    private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    void Start(){
        gameManager = GameManager.instance;
    }
    void OnTriggerStay(Collider _col)  //STAY
    {
        if (Input.GetKeyDown(KeyCode.F)){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "영!차!";
            transform.position=new Vector3(transform.position.x,transform.position.y, 35.0f);
        }
    }


    void OnTriggerExit(Collider other)
     {
        if (animator.GetBool("IsOpen") == true){
            animator.SetBool("IsOpen", false);
            return;
            }
    }

}