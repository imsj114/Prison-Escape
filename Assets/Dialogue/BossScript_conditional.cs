using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript_Conditional : MonoBehaviour
{
    public Dialogue dialogue;
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    private int size;
    private int cnt;

    // Start is called before the first frame update
    void Start()
    {
        size = dialogue.sentences.Length;
        cnt = 0;
    }
    void OnTriggerStay(Collider other)
    {
      
        if (true){  //먹을거 조건문
            if (Input.GetKeyDown(KeyCode.F) && cnt == 0){
                sentences = new Queue<string>();
                animator.SetBool("IsOpen", true);
                sentences.Clear();
                nameText.text = dialogue.name;
                foreach(string sentence in dialogue.sentences)
                {
                    sentences.Enqueue(sentence);
                }
                string out_sentence = sentences.Dequeue();
                dialogueText.text = out_sentence;
                cnt++;
                return;
            }

            if (Input.GetKeyDown(KeyCode.F) && cnt !=0 && cnt < size){   
                string sentence = sentences.Dequeue();
                dialogueText.text = sentence;
                cnt++;
                return;
            }

            if (Input.GetKeyDown(KeyCode.F) && cnt == size){
                animator.SetBool("IsOpen", false);
                cnt = 0;
                return;
            }
        } else{
            if (Input.GetKeyDown(KeyCode.F) && cnt == 0){
                animator.SetBool("IsOpen", true);
                nameText.text = dialogue.name;
                dialogueText.text = "나에게 맛있는걸 가져다 줘!";
                cnt ++;
                return;
            }
            if (Input.GetKeyDown(KeyCode.F) && cnt == 1){
                animator.SetBool("IsOpen", false);
                cnt = 0;
                return;
            }
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

