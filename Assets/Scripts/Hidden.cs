using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Hidden : MonoBehaviour
{
    public Text nameText;
    
    private GameManager gameManager;
    public Text dialogueText;
    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator.SetBool("IsOpen", false);
        gameManager=GameManager.instance;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag =="Player" && !(gameManager.items["groundDigged"])){
            Debug.Log("들어감");
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "이것들을 F, G를 눌러서 치우고 저기로 가야겠다!";
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
