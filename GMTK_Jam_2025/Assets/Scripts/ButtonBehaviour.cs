using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{

    public GameObject wall = null;
    public bool active = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (wall != null)
        {
            wall.SetActive(false);
        }
        
        active = true;
}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (wall != null)
        {
            wall.SetActive(true);
        }
        active = false;
}
}
