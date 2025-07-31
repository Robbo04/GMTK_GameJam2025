using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnersGateScript : MonoBehaviour
{
    [SerializeField] GameObject parentObject;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Level Complete");
        Destroy(parentObject);
    }
}

