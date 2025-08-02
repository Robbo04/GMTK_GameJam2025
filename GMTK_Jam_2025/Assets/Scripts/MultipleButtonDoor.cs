using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleButtonDoor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> buttons;
    int buttonQuantity;
    public int activeCount = 0;

    private void Start()
    {
        buttonQuantity = buttons.Count;
        //print(buttonQuantity);
    }

    private void Update()
    {
        CheckAll();
    }

    private void CheckAll()
    {
        activeCount = 0;
        foreach (GameObject button in buttons)
        {
            if (button.GetComponent<ButtonBehaviour>().active)
            {
                activeCount++;
            }
        }
        if (activeCount == buttonQuantity)
        {
            this.GetComponent<BoxCollider2D>().isTrigger = true;
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            this.GetComponent<BoxCollider2D>().isTrigger = false;
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
