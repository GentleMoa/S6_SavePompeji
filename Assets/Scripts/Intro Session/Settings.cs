using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    //Public Variables
    //Variables used in Script "Cube"
    public Material playerMaterial_default;
    public Material playerMaterial_alternative;
    public Material enemyMaterial_default;
    public Material enemyMaterial_alternative;
    public Material errorMaterial;
    public int playerHP = 100;
    public int enemyHP = 200;
    public Animator _animatorPlayer;
    public Animator _animatorEnemy;

    //Variables used in Script "Spawner"
    public GameObject player;
    public GameObject enemy;
    [HideInInspector]
    public float _spawnPerimeterX;
    [HideInInspector]
    public float _spawnPerimeterZ;

    [Header("This value determines the maximal spawn perimeter!")]
    public float _maxSpawnPerimeter = 3.0f;
    [Header("This value determines the maximal spawn perimeter!")]
    public float _spawnHeight = 0.5f;
}
