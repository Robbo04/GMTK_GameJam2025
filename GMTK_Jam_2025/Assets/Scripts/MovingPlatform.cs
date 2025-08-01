using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovingPlatform : MonoBehaviour
{
    GameObject platform;
    Vector3 startPos;
    Vector3 endPos;
    bool moving_left;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        platform = transform.GetChild(0).gameObject;
        startPos = transform.GetChild(1).localPosition;
        endPos = transform.GetChild(2).localPosition;
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        player.transform.SetParent(transform, true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        player.transform.SetParent(null, true);
    }*/

    // Update is called once per frame
    void Update()
    {
        if (moving_left)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);

            if (transform.localPosition.x <= startPos.x)
            {
                moving_left = false;
            }
        }

        if (!moving_left)
        {
            transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);

            if (transform.localPosition.x >= endPos.x)
            {
                moving_left = true;
            }
        }
    }
}
