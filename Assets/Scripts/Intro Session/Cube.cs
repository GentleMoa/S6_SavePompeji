using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Public Variables
    public GameObjectType type;
    public string title;
    public Renderer _renderer;

    //Private Variables
    private Settings _settings;
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

    public Material SwitchMaterial(GameObjectType _type)
    {
        if (_type == GameObjectType.Player)
        {
            return _settings.playerMaterial_alternative;
        }
        else if (_type == GameObjectType.Enemy)
        {
            return _settings.enemyMaterial_alternative;
        }
        return _settings.errorMaterial;
    }

    public void CubeAnimation(GameObjectType _type)
    {
        if (_type == GameObjectType.Player)
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("animTrigger");
        }
        else if (_type == GameObjectType.Enemy)
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("animTrigger");
        }
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
            return _settings.playerMaterial_default;
        }
        else if (_type == GameObjectType.Enemy)
        {
            return _settings.enemyMaterial_default;
        }
        Debug.LogWarning("GameObjectType.LifePoints: _type is unknown");
        return _settings.errorMaterial;
    }
}
