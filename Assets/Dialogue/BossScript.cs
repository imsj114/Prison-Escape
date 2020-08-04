using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : MonoBehaviour
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
            return;
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

