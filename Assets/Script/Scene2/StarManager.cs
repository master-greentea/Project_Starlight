using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public Sprite[] stars;
    public Transform star_Prefab;
    //spawn pos
    private float spawn_x = 0;
    private float spawn_y = 0;
    // used in star killer
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public bool respawn = false;

    public int counter = 0;
    public int global_star_count = 0;
    public int global_star_limit = 600;
    public int total_star_spawned = 0;

    void Start()
    {
    }

    void Update()
    {
        // initiate
        if (counter < 150) {
            counter++;
            global_star_count++;

            spawn_x = Random.Range(-14f, 14f);
            spawn_y = Random.Range(-14f, 14f);

            Transform new_star = Instantiate(star_Prefab, transform.position, Quaternion.Euler(0f, 0f, 0f));
            new_star.GetComponent<SpriteRenderer>().sprite = stars[Random.Range(0, stars.Length)];

            Vector3 target_pos = new Vector3(spawn_x, spawn_y, 0f);
            transform.position = target_pos;
            total_star_spawned++;
        }
        // respawn
        else if (respawn && counter < 210 && global_star_count <= global_star_limit) {
            Transform new_star = Instantiate(star_Prefab, transform.position, Quaternion.Euler(0f, 0f, 0f));
            new_star.GetComponent<SpriteRenderer>().sprite = stars[Random.Range(0, stars.Length)];

            spawn_x = Random.Range(minX, maxX);
            spawn_y = Random.Range(minY, maxY); 

            Vector3 target_pos = new Vector3(spawn_x, spawn_y, 0f);
            transform.position = target_pos;

            counter++;
            global_star_count++;
            total_star_spawned++;
        }
        
        //Debug.Log(counter);
    }
}
