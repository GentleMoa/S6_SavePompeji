using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header ("Use the keyboard buttons 'P' and 'E' to spawn players or enemies!")]
    //Used to force a line break in the inspector
    [Header ("")]

    //Public Variables
    public GameObject player;
    public GameObject enemy;

    //Private Variables accessable from the inspector
    [Header ("This value determines the maximal spawn perimeter!")]
    [SerializeField] private float _maxSpawnPerimeter = 3.0f;
    [Header("This value determines the height of spawning objects!")]
    [SerializeField] private float _spawnHeight = 0.5f;

    //Private Variables
    private float _spawnPerimeterX;
    private float _spawnPerimeterZ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            SpawnPlayer();
        }

        if (Input.GetKeyDown("e"))
        {
            SpawnEnemy();
        }
    }

    private void SpawnPlayer()
    {
        //Randomizing the spawn perimeter based on a threshold (for X value)
        _spawnPerimeterX = Random.Range(-_maxSpawnPerimeter, _maxSpawnPerimeter);
        //Randomizing the spawn perimeter based on a threshold (for Z value)
        _spawnPerimeterZ = Random.Range(-_maxSpawnPerimeter, _maxSpawnPerimeter);

        Instantiate(player, new Vector3(_spawnPerimeterX, _spawnHeight, _spawnPerimeterZ), Quaternion.identity);
    }

    private void SpawnEnemy()
    {
        //Randomizing the spawn perimeter based on a threshold (for X value)
        _spawnPerimeterX = Random.Range(-_maxSpawnPerimeter, _maxSpawnPerimeter);
        //Randomizing the spawn perimeter based on a threshold (for Z value)
        _spawnPerimeterZ = Random.Range(-_maxSpawnPerimeter, _maxSpawnPerimeter);

        Instantiate(enemy, new Vector3(_spawnPerimeterX, _spawnHeight, _spawnPerimeterZ), Quaternion.identity);
    }
}
