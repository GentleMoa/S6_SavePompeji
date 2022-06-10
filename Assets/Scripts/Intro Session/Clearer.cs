using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearer : MonoBehaviour
{
    //Public Variables
    public List<GameObject> players = new List<GameObject>();
    public List<GameObject> enemies = new List<GameObject>();

    //Public Functions
    public void ClearPlayersAndEnemies()
    {
        players.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        enemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));

        for(int i = 0; i < players.Count; i++)
        {
            Destroy(players[i]);
        }

        for (int i = 0; i < enemies.Count; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
