using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
