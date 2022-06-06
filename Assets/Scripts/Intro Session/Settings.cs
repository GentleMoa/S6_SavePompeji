using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    //Public Variables
    //Variables used in Script "Cube"
    public Material playerMaterial;
    public Material enemyMaterial;
    public Material errorMaterial;
    public int playerHP = 100;
    public int enemyHP = 200;

    //Variables used in Script "Spawner"
    public GameObject player;
    public GameObject enemy;
    public float _spawnPerimeterX;
    public float _spawnPerimeterZ;

    [Header("This value determines the maximal spawn perimeter!")]
    public float _maxSpawnPerimeter = 3.0f;
    [Header("This value determines the maximal spawn perimeter!")]
    public float _spawnHeight = 0.5f;
}
