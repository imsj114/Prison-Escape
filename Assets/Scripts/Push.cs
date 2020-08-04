using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Push : MonoBehaviour
{
void OnTriggerStay(Collider _col)  //STAY
    {
        Debug.Log("CollideP");
        if (Input.GetKeyDown(KeyCode.P)){
           transform.position=new Vector3(transform.position.x,transform.position.y,35.0f);
        }
    }

}
