using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{

    public GameObject wall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wall.SetActive(true);
    }
}
