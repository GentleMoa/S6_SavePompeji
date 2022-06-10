using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class TouchManager : MonoBehaviour
{
    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = GameManager.Instance;
    }

    void OnEnable()
    {
        LeanTouch.OnFingerTap += OnTap;
    }

    void OnDisable()
    {
        LeanTouch.OnFingerTap -= OnTap;
    }

    void OnTap(LeanFinger finger)
    {
        Debug.Log("You just tapped the screen with finger: " + finger.Index + "at"  + finger.ScreenPosition);
        _gameManager.OnTap(finger);
    }
}
