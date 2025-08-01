using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProtection : MonoBehaviour
{
    public bool IsInside = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            IsInside = true;
        }
        else
        {
            IsInside = false;
        }
    }
}
