using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarKiller : MonoBehaviour
{
    public StarManager sad;

    void Start()
    {
    }

    void OnTriggerExit2D(Collider2D activator)
    {
        sad.minX =activator.transform.position.x * -0.5f;
        sad.maxX = activator.transform.position.x * -0.9f;
        sad.minY = activator.transform.position.y * -0.5f;
        sad.maxY =activator.transform.position.y * -0.9f;

        sad.respawn = true;

        Destroy(activator.gameObject);
        sad.global_star_count--;
        sad.counter = 151;
    }
}
