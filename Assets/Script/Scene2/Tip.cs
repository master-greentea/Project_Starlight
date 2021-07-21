using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip : MonoBehaviour
{
    public Animator animator;
    public float tip_wait_time;

    IEnumerator TipWait(float waiTime) {
        yield return new WaitForSeconds(waiTime);
        animator.SetTrigger("TipIn");
    }

    private Coroutine tw; 
    
    void Start()
    {
        tw = StartCoroutine(TipWait(tip_wait_time));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            StopCoroutine(tw);
            animator.SetTrigger("TipOut");
        }
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space)) {
            //tw = StartCoroutine(TipWait(20f));
        }
    }
}
