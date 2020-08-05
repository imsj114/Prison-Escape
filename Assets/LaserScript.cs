using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public GameObject laser1;
    public GameObject laser2;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F)){
            Debug.Log("touch~!");
            laser1.SetActive(false);
            laser2.SetActive(false);
            var buttonRender = button.GetComponent<Renderer>();
            buttonRender.material.SetColor("_Color", Color.red);
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
