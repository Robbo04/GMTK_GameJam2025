using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProtection : MonoBehaviour
{
    public bool IsInside = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && other.GetComponent<PlayerScript>().isActiveAndEnabled)
        {
            IsInside = true;
            other.gameObject.GetComponent<PlayerScript>().isInSafety = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if ((other.tag == "Player") && other.GetComponent<PlayerScript>().isActiveAndEnabled)
        {
            IsInside = false;
            other.gameObject.GetComponent<PlayerScript>().isInSafety = false;
        }
    }

    private void Update()
    {
        //print(IsInside);
    }
}
