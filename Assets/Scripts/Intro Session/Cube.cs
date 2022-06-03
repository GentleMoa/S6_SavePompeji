using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Public Variables
    public GameObjectType type;
    public string title;

    //Private Variables
    private Settings _settings;
    private Renderer _renderer;
    private int _lifePoints;

    // Start is called before the first frame update
    void Start()
    {
        _settings = FindObjectOfType<Settings>();
        _renderer = GetComponent<Renderer>();
        _lifePoints = LifePointsFor(type);

        if (_renderer != null && _settings != null)
        {
            _renderer.material = MaterialFor(type);
        } 
        else
        {
            if (_renderer == null)
            {
                Debug.LogWarning($"{title}: _renderer is null!", this);
            }

            if (_settings == null)
            {
                Debug.LogWarning($"{title}: _settings is null!", this);
            }
        }
    }

    //Public Methods
    public void AddLifePoints(int points)
    {
        _lifePoints += points;
    }

    //Private Methods
    private int LifePointsFor(GameObjectType _type)
    {
        switch (_type)
        {
            case GameObjectType.Player:
                return _settings.playerHP;
            case GameObjectType.Enemy:
                return _settings.enemyHP;
            default:
                Debug.LogWarning("GameObjectType.LifePoints: _type is unknown");
                return 0;
        }
    }

    private Material MaterialFor(GameObjectType _type)
    {
        if (_type == GameObjectType.Player)
        {
            return _settings.playerMaterial;
        }
        else if (_type == GameObjectType.Enemy)
        {
            return _settings.enemyMaterial;
        }
        Debug.LogWarning("GameObjectType.LifePoints: _type is unknown");
        return _settings.errorMaterial;
    }
}
