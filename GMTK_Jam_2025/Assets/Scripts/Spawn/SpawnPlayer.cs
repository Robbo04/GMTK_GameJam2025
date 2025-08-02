using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPlayer : MonoBehaviour
{
    //SerializeFields
    [SerializeField] public GameObject spawnProtection;
    [SerializeField] private GameObject gameObjectToSpawn;
    [SerializeField] private GameObject gameObjectToSpawnBouncy;
    [SerializeField] private GameObject gameObjectToSpawnHeavy;
    [SerializeField] private GameObject cubeCountObject;
    //Variables
    public int livesLeft = 2;
    //Array of Cubes
    GameObject[] players;
    public int playerType;
    public List<int> objectType = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        players = new GameObject[livesLeft];
        CreatePlayer();
        
    }

    // Update is called once per frame
    public void Spawn()
    {
        if (livesLeft > 0)
        {
            if (!spawnProtection.GetComponent<SpawnProtection>().IsInside)
            {
                CreatePlayer();
                //if ()
                //print(spawnProtection.GetComponent<SpawnProtection>().IsInside);
            }
        }
    }

    public void CreatePlayer()
    {
        
        switch (objectType[0])
        {
            case 0:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawn, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                break;
            case 1:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawnBouncy, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                break;
            case 2:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawnHeavy, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                break;
            default:
                print("Error");
                break;
        }
        cubeCountObject.GetComponent<cubeCount>().RemoveNext();
    }
}
