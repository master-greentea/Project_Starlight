using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public float spin_speed = 0f;
    public float move_speed = 0f;
    private GameObject[] UI;

    private Vector3 mouse_origin;

    void Start()
    {
        if (gameObject.tag == "Star") {
            move_speed = 0;
            StartCoroutine(StarWait());
        }
    }

    IEnumerator StarWait() {
        yield return new WaitForSeconds(.5f);
        move_speed = Random.Range(0.0099f, 0.035f);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, Time.deltaTime * spin_speed, Space.Self);

        UI = GameObject.FindGameObjectsWithTag("UI");
        if (UI.Length == 0) {

            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
                //mouse_origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouse_origin = new Vector3(0f, 0f, 0f);
            }
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
                Vector3 difference = new Vector3(mouse_origin.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x, mouse_origin.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);
                transform.position += difference * move_speed;
            }

            if (gameObject.tag == "Star" && Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space)) {
                move_speed = Random.Range(0.0099f, 0.035f);
            }
            
        }
    }
}
