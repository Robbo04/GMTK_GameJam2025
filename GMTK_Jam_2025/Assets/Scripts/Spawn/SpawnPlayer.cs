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
    public int livesLeft;
    //Array of Cubes
    GameObject[] players;

    private int objectTypeCount = 0;

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
        int upcomingPlayer = cubeCountObject.GetComponent<cubeCount>().GetUpcoming();
        print(upcomingPlayer);
        switch (upcomingPlayer)
        {
            case 0:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawn, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                cubeCountObject.GetComponent<cubeCount>().RemoveNext();
                objectTypeCount++;
                break;
            case 1:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawnBouncy, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                cubeCountObject.GetComponent<cubeCount>().RemoveNext();
                objectTypeCount++;
                break;
            case 2:
                players[livesLeft - 1] = Instantiate(gameObjectToSpawnHeavy, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
                livesLeft--;
                cubeCountObject.GetComponent<cubeCount>().RemoveNext();
                objectTypeCount++;
                break;
            default:
                print("Error");
                break;
        }
        
    }
}
