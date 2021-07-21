using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Sprite light;
    public float minWait;
    public float maxWait;
    public GameObject stars;
    public GameObject stars2;
    public float waitFrames;

    private bool on;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        on = true;
        counter = 0;
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker() {
        while (counter <= waitFrames) {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));
            on = ! on;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (on) {
            GetComponent<SpriteRenderer>().sprite = light;
        }
        else {
            GetComponent<SpriteRenderer>().sprite = null;
        }
        counter++;
        if (counter > waitFrames) {
            on = true;
            stars.SetActive(true);
            stars2.SetActive(true);
        }
    }
}
