using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public Material mat_blend;
    public Material mat_bloom;
    public int text_index;
    public UI uI;

    private bool unlocked;

    void Start()
    {
        unlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().color == Color.white) {
            unlocked = true;
        }
    }

    void OnMouseOver()
    {
        if (unlocked) {
            GetComponent<SpriteRenderer>().material = mat_bloom;
        }
    }

    void OnMouseExit()
    {
        if (unlocked) {
            GetComponent<SpriteRenderer>().material = mat_blend;
        }
    }

    void OnMouseDown() {
        if (unlocked) {
            uI.state = text_index;
            GetComponent<AudioSource>().Play();
        }
    }
}
