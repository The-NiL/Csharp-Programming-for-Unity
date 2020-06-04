using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject rockPrefab;

    [SerializeField]
    Sprite magentaRock;

    [SerializeField]
    Sprite whiteRock;

    [SerializeField]
    Sprite greenRock;

    // spawn control
    const float minSpawnDelay = 1;
    const float maxSpawnDelay = 2;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBoarderSize = 100 ;
    int minSpawnX;
    int minSpawnY;
    int maxSpawnX;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        // boundries for spawning rocks
        minSpawnX = SpawnBoarderSize;
        minSpawnY = SpawnBoarderSize;
        maxSpawnX = Screen.width - minSpawnX;
        maxSpawnY = Screen.height - minSpawnY;

        // set timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(minSpawnDelay, maxSpawnDelay);
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        // get all game objects in the scene with rock tag
        GameObject[] objects = GameObject.FindGameObjectsWithTag("rock");

        // control number of rocks which can be in the game at the same time
        if (spawnTimer.Finished && objects.Length <= 3)
        {
            spawnRock();
            spawnTimer.Run();
        }
    }

    // spawn rocks in a random location with random sprites
    void spawnRock()
    {
        // generate random rocks within boundries
        Vector3 location = new Vector3(
            Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);

        // converting location
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        // instantiate a new rock
        GameObject rock = Instantiate(rockPrefab) as GameObject;

        // place the rock in the world location
        rock.transform.position = worldLocation;

        // random sprite for spawned rock
        SpriteRenderer newRock = rock.GetComponent<SpriteRenderer>();
        int randomRock = Random.Range(0, 3);
        if (randomRock == 0)
        {
            newRock.sprite = magentaRock;
        }

        else if (randomRock == 1)
        {
            newRock.sprite = greenRock;
        }

        else
        {
            newRock.sprite = whiteRock;
        }
    }
}
