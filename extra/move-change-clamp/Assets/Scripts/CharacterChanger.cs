using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject characterPrefab0;

    [SerializeField]
    GameObject characterPrefab1;

    [SerializeField]
    GameObject characterPrefab2;

    [SerializeField]
    GameObject characterPrefab3;

    // Start is called before the first frame update
    void Start()
    {
        // spawn character 0 by default after game starts
        int randomCharacter = Random.Range(0, 4);
        Vector3 location = Input.mousePosition;
        location = Camera.main.ScreenToWorldPoint(location);

        Instantiate<GameObject>(characterPrefab0, location, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        int randomCharacter = Random.Range(0, 4);
        Vector3 location = Input.mousePosition;
        location = Camera.main.ScreenToWorldPoint(location);

        // get all available objects in the scene with provided tag
        GameObject[] sceneObject = GameObject.FindGameObjectsWithTag("character");

        // if user righ clicks spawn a random character in the current mouse location
        if (Input.GetMouseButtonDown(1))
        {
            if (randomCharacter == 0)
                Instantiate<GameObject>(characterPrefab0, location, Quaternion.identity);

            else if (randomCharacter == 1)
                Instantiate<GameObject>(characterPrefab1, location, Quaternion.identity);

            else if (randomCharacter == 2)
                Instantiate<GameObject>(characterPrefab2, location, Quaternion.identity);

            else
                Instantiate<GameObject>(characterPrefab3, location, Quaternion.identity);

            // destroy last object after spawn one
            Destroy(sceneObject[0]);
        }
        
    }
}
