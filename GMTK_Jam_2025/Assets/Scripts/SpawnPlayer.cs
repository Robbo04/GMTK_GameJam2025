using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPlayer : MonoBehaviour
{
    //SerializeFields
    [SerializeField] private GameObject gameObjectToSpawn;
    [SerializeField] public GameObject spawnprotection; 
    //Variables
    public int livesLeft = 2;
    //Array of Cubes
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
            if (spawnprotection.GetComponent<SpawnProtection>().IsInside == false)
            {
                players[livesLeft - 1] = Instantiate(gameObjectToSpawn, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
            }
            
        }
    }
}
