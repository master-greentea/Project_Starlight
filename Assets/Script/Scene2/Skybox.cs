using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    public float rotationSpeed;
    private Vector3 mouse_origin;
    void Start()
    {
        rotationSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time + rotationSpeed);
        //To set the speed, just multiply Time.time with whatever amount you want.
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            //mouse_origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse_origin = new Vector3(0f, 0f, 0f);
            }
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
            Vector3 difference = new Vector3(mouse_origin.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x, mouse_origin.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);
            rotationSpeed += difference.x * .01f;
        }
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space)) {
            rotationSpeed = rotationSpeed;
        }
    }
}
