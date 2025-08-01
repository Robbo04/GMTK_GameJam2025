using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class HydrPress : MonoBehaviour
{

    bool descend = true;
    public float speed = 0.01f;

    void Start()
    {
        transform.localPosition = new Vector3(-0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (descend)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y - speed, 0);

            if (transform.localPosition.y <= -1)
            {
                descend = false;
            }
        }

        if (!descend)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y + speed, 0);

            if (transform.localPosition.y >= 0)
            {
                descend = true;
            }
        }
    }
}
