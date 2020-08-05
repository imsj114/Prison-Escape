using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserScript : MonoBehaviour
{
    public GameObject laser1;
    public GameObject laser2;
    public GameObject button;

    private GameManager gameManager;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    void OnTriggerStay(Collider other)
    {
        bool has_cardKey = gameManager.items["cardKey"];
        if (has_cardKey){
            if (Input.GetKeyDown(KeyCode.F)){
                laser1.SetActive(false);
                laser2.SetActive(false);
                var buttonRender = button.GetComponent<Renderer>();
                buttonRender.material.SetColor("_Color", Color.red);
                animator.SetBool("IsOpen", true);
                nameText.text = "나의 생각";
                dialogueText.text = "성공!";
                return;
            }
        }else {
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "이런... 이 레이져 때문에 탈옥을 못하겠어! 과거로 가서 해결책을 찾자!";
            return;
        }
    
    }
     void OnTriggerExit(Collider other)
     {
       if (animator.GetBool("IsOpen") == true){
            animator.SetBool("IsOpen", false);
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
