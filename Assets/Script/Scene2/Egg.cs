using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public Sprite[] eggs;
    public StarGazer starGazer;
    public Animator animator;
    public Material mat_blend;
    public Material mat_bloom;

    public GameObject UI;
    public UI uI;

    public int test;

    void Start()
    {
    }

    public IEnumerator EggDeactivate(float wtime) {
        yield return new WaitForSeconds(wtime);
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (starGazer.canEgg) {
            SpritePicker();
        }
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        UI.SetActive(true);
        GetComponent<CircleCollider2D>().enabled = false;

        starGazer.smallest_egg_number += 50;
        starGazer.smallest_star_spawned += 2000;
        starGazer.canEgg = false;
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().material = mat_bloom;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().material = mat_blend;
    }

    void SpritePicker() {
        if (starGazer.smallest_egg_number == 100) {
            GetComponent<SpriteRenderer>().sprite = eggs[0];
            uI.state = 1;
        }
        else if (starGazer.smallest_egg_number == 150) {
            GetComponent<SpriteRenderer>().sprite = eggs[1];
            uI.state = 2;
        }
        else if (starGazer.smallest_egg_number == 200 || starGazer.smallest_star_spawned == 2000) {
            GetComponent<SpriteRenderer>().sprite = eggs[2];
            uI.state = 3;
        }
        else if (starGazer.smallest_egg_number == 250 || starGazer.smallest_star_spawned == 4000) {
            GetComponent<SpriteRenderer>().sprite = eggs[3];
            uI.state = 4;
        }
        else if (starGazer.smallest_egg_number == 300 || starGazer.smallest_star_spawned == 6000) {
            GetComponent<SpriteRenderer>().sprite = eggs[4];
            uI.state = 5;
        }
        else if (starGazer.smallest_egg_number == 350 || starGazer.smallest_star_spawned == 8000) {
            GetComponent<SpriteRenderer>().sprite = eggs[5];
            uI.state = 6;
        }
        else if (starGazer.smallest_egg_number == 400 || starGazer.smallest_star_spawned == 10000) {
            GetComponent<SpriteRenderer>().sprite = eggs[6];
            uI.state = 7;
        }
    }
}
