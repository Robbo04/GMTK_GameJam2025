using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class HydrPress : MonoBehaviour
{

    bool descend = true;
    public float speed = 100f;

    void Start()
    {
        transform.localPosition = new Vector3(-0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (descend)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - speed, transform.localPosition.z);

            if (transform.localPosition.y <= -1)
            {
                descend = false;
            }
        }

        if (!descend)
        {
            transform.localPosition = new(transform.localPosition.x, transform.localPosition.y + speed, transform.localPosition.z);

            if (transform.localPosition.y >= 0)
            {
                descend = true;
            }
        }
    }
}
