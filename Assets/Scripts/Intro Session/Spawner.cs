using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Some infos for this script that can be seen in the inspector 
    [Header ("Use the keyboard buttons 'P' and 'E' to spawn players or enemies!")]
    [Header ("")]

    //Private Variables
    private Settings _settings;

    private void Start()
    {
        _settings = FindObjectOfType<Settings>();
    }

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
        _settings._spawnPerimeterX = Random.Range(- _settings._maxSpawnPerimeter, _settings._maxSpawnPerimeter);
        //Randomizing the spawn perimeter based on a threshold (for Z value)
        _settings._spawnPerimeterZ = Random.Range(- _settings._maxSpawnPerimeter, _settings._maxSpawnPerimeter);

        Instantiate(_settings.player, new Vector3(_settings._spawnPerimeterX, _settings._spawnHeight, _settings._spawnPerimeterZ), Quaternion.identity);
    }

    private void SpawnEnemy()
    {
        //Randomizing the spawn perimeter based on a threshold (for X value)
        _settings._spawnPerimeterX = Random.Range(-_settings._maxSpawnPerimeter, _settings._maxSpawnPerimeter);
        //Randomizing the spawn perimeter based on a threshold (for Z value)
        _settings._spawnPerimeterZ = Random.Range(-_settings._maxSpawnPerimeter, _settings._maxSpawnPerimeter);

        Instantiate(_settings.enemy, new Vector3(_settings._spawnPerimeterX, _settings._spawnHeight, _settings._spawnPerimeterZ), Quaternion.identity);
    }
}
