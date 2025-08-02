using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{

    public GameObject wall;
    public bool active = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.SetActive(false);
        bool active = true;
}

    private void OnTriggerExit2D(Collider2D collision)
    {
        wall.SetActive(true);
        bool active = false;
}
}
