using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    public Vector2 force1;
    public Rigidbody2D bubbleRgb;

    public GameObject nextBubble;
    // Start is called before the first frame update
    void Start()
    {
        bubbleRgb.AddForce(force1, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if(nextBubble != null)
        {
            GameObject Bubble1 = Instantiate(nextBubble, bubbleRgb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject Bubble2 = Instantiate(nextBubble, bubbleRgb.position + Vector2.left / 4f, Quaternion.identity);

            Bubble1.GetComponent<BubbleController>().force1 = new Vector2(2f, 5f);
            Bubble2.GetComponent<BubbleController>().force1 = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }

   
}
