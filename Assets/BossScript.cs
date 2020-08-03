using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F)){
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
