using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Item : MonoBehaviour
{
    public Sprite DefaultImg;   // 기본 이미지.
    public int MaxCount;        // 겹칠수 있는 최대 숫자.  
 
    // 인벤토리에 접근하기 위한 변수.
    private Inventory Iv;

    private GameManager manager;

    private Animator anim;

    public Text nameText;
    public Text dialogueText;
    public Animator animator;


    public string itemType;
 

    void Start()
    {
        
    }
    void Awake()
    {
        // 태그명이 "Inventory"인 객체의 GameObject를 반환한다.
        // 반환된 객체가 가지고 있는 스크립트를 GetComponent를 통해 가져온다.
        manager = GameManager.instance;
        Iv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

    }
 
    void AddItem()
    {
        
        Iv.AddItem(this);
        gameObject.SetActive(false); // 아이템을 비활성화 시켜준다.
        manager.items[itemType]=true; // 특정 아이템을 가지고 있다.
    }
 
    // 충돌체크
    void OnTriggerStay(Collider _col)  //STAY
    {  
        if (Input.GetKeyDown(KeyCode.F) && _col.tag == "Player"){
            AddItem();
            if (animator.GetBool("IsOpen") == true)
            {
                animator.SetBool("IsOpen", false);
                return;
            }
        }
        else{
            if(animator.GetBool("IsOpen") == false && _col.tag == "Player"){
            animator.SetBool("IsOpen", true);
            nameText.text = "나의 생각";
            dialogueText.text = "쓸모있는 물건 같은데? 챙겨가면 어딘가에 쓸 수 있겠어";
            return;  
            }
        }
    }

    void OnTriggerExit(Collider _col)
     {
        if (animator.GetBool("IsOpen") == true){
            animator.SetBool("IsOpen", false);
            return;
            }
    }
}
 