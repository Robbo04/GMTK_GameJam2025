using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyorLeft : MonoBehaviour
{
    BoxCollider2D t_volume;
    public List<GameObject> objectsOnBelt = new List<GameObject>();
    public int speed = 1;

    private void Start()
    {
        BoxCollider2D t_volume = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectsOnBelt.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        objectsOnBelt.Remove(collision.gameObject);
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < objectsOnBelt.Count; i++)
        {
            GameObject obj = objectsOnBelt[i];
            obj.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
