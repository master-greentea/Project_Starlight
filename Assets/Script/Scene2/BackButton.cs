using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject UI;
    public Animator[] ui_animators;
    public StarGazer starGazer;

    public Sprite bah;
    public Sprite unbah;

    IEnumerator UIDeactivate() {
        yield return new WaitForSeconds(.75f);
        starGazer.canEgg = true;
        UI.SetActive(false);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            CloseUI();
        }
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        CloseUI();
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = bah;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = unbah;
    }

    void CloseUI() {
        StartCoroutine(UIDeactivate());
        foreach(Animator ani in ui_animators) {
            ani.SetBool("EggOut", true);
        }
    }
}
