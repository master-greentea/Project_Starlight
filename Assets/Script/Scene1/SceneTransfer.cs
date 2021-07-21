using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    public string sceneToGo;
    public Animator animator;

    void Update() {
        if (StartButton.transit && "Scene1" == SceneManager.GetActiveScene().name) {
            animator.SetTrigger("FadeOut");
        }    
    }

    public void OnFadeComplete() {
        if ("Scene1" == SceneManager.GetActiveScene().name) {
            SceneManager.LoadScene(sceneToGo);
        }
    }
}
