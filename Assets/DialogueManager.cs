using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;


    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        sentences.Clear();

        nameText.text = dialogue.name;
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        while (sentences.Count != 0){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplayNextSentence();
            }
        }
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }


    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }


}
