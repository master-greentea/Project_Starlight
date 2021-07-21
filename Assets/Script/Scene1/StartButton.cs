using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string sceneToGo;
    public static bool transit;
    private float alpha;
    public Sprite glow;
    public Sprite no_glow;
    public AudioSource stat;
    
    void Start()
    {
        transit = false;
    }

    void OnMouseDown()
    {
        transit = true;
        StartCoroutine(AudioFadeOut.FadeOut(stat, .8f));
        GetComponent<AudioSource>().Play();
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = glow;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = no_glow;
    }
}
