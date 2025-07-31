using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject gameObjectToSpawn;
    public int livesLeft = 2;

    GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        players = new GameObject[livesLeft];
        Spawn();
    }

    // Update is called once per frame
    public void Spawn()
    {
        if (livesLeft > 0)
        {
            players[livesLeft-1] = Instantiate(gameObjectToSpawn, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
            livesLeft--;
            print(livesLeft);
        }
    }
}
