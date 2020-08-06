﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeCollider : MonoBehaviour
{
    public string nextScene;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            //SceneManager.LoadScene(nextScene);
            GameManager.instance.stages["present"] = 1;
            Initiate.Fade(nextScene,Color.black,1f);
        }
    }
}
