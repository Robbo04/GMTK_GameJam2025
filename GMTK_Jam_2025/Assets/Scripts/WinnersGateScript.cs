using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnersGateScript : MonoBehaviour
{
    public GameObject flag_raised_image;
    public GameObject flag_lowered_image;

    private void Start()
    {
        FlagRaised(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Level Complete");
        //Destroy(this.gameObject);
        FlagRaised(true);
    }

    private void FlagRaised(bool GateReached)
    {
        if (GateReached)
        {
            flag_raised_image.GetComponent<Renderer>().enabled = true;
            flag_lowered_image.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            flag_raised_image.GetComponent<Renderer>().enabled = false;
            flag_lowered_image.GetComponent<Renderer>().enabled = true;
        }
    }
}



