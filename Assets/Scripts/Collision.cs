using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        WireController.blast = false;

        if (collider.tag == "Bubble")
        {
            collider.GetComponent<BubbleController>().Split();
        }
    }
}
