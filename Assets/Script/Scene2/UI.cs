using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public SpriteRenderer[] eggs_collection;
    public CurrentEgg currentEgg;
    public StarGazer starGazer;
    public StarManager starManager;
    public int state = 0;

    //text
    public Text stars_gazed;

    void Start()
    {
    }

    void Update()
    {
        CollectionShow(state);
        TextChange();
    }

    public void TextChange() {
        stars_gazed.text = "已经看到" + starManager.total_star_spawned.ToString() + "颗星星啦！";
    }

    void CollectionShow(int current_state) {
        if (current_state == 1) {
            eggs_collection[0].color = Color.white;
        }
        if (current_state == 2) {
            eggs_collection[1].color = Color.white;
        }
        if (current_state == 3) {
            eggs_collection[2].color = Color.white;
        }
        if (current_state == 4) {
            eggs_collection[3].color = Color.white;
        }
        if (current_state == 5) {
            eggs_collection[4].color = Color.white;
        }
        if (current_state == 6) {
            eggs_collection[5].color = Color.white;
        }
        if (current_state == 7) {
            eggs_collection[6].color = Color.white;
            starGazer.smallest_star_spawned = 100000;
        }
        currentEgg.show_text_index = current_state;
    }
}
