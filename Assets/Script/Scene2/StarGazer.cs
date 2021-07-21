using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGazer : MonoBehaviour
{
    public float star_number;
    private Collider2D[] stars;
    public StarManager starManager;

    public GameObject egg_obj;
    public Egg egg;
    private GameObject[] eggs;
    public int smallest_egg_number = 100;
    public int smallest_star_spawned = -2000;
    public bool canEgg;

    public GameObject UI;

    void Start()
    {
        canEgg = true;
    }

    void Update()
    {
        stars = Physics2D.OverlapBoxAll(new Vector2(0f, 0f), new Vector2(13f, 9f), 0f);
        star_number = stars.Length - 1;

        eggs = GameObject.FindGameObjectsWithTag("Egg");
        if (eggs.Length == 0 && (star_number >= smallest_egg_number || (smallest_star_spawned >= 2000 && starManager.total_star_spawned >= smallest_star_spawned)) && canEgg) {
            EggState(true);
        }
        if (eggs.Length != 0 && (star_number < smallest_egg_number && smallest_star_spawned < 2000)){
            EggState(false);
        }
        if (!canEgg) {
            EggState(false);
        }

        if (Input.GetKeyDown(KeyCode.Tab)) {
            UI.SetActive(true);
        }

        Debug.Log(star_number);
    }

    void EggState(bool eggState) {
        if (eggState) {
            egg_obj.SetActive(eggState);
            egg_obj.GetComponent<CircleCollider2D>().enabled = true;
            egg.animator.SetBool("EggOut", false);
        }
        else {
            egg.animator.SetBool("EggOut", true);
            StartCoroutine(egg.EggDeactivate(.75f));
        }
    }
}
