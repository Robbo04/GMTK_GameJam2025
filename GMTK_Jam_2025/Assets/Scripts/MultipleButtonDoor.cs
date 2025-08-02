using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleButtonDoor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> buttons;
    int buttonQuantity;

    private void Start()
    {
        buttonQuantity = buttons.Count;
        print(buttonQuantity);
    }

    private void CheckAll()
    {
        for (int i = 0; i < buttons.Count; i++)
        {

        }
    }
}
