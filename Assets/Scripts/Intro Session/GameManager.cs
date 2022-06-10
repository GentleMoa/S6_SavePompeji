using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance
    {
        get
        {
            return FindObjectOfType<GameManager>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Event Handlers
    public void OnTap(LeanFinger finger)
    {
        //Create a raycast
        Ray ray = Camera.main.ScreenPointToRay(finger.ScreenPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            GameObject hitGameObject = hit.collider.gameObject;
            Cube hitCubeObject = hitGameObject.GetComponent<Cube>();

            if (hitCubeObject != null)
            {
                hitCubeObject._renderer.material = hitCubeObject.SwitchMaterial(hitCubeObject.type);
                Debug.Log("Material changed for: " + hitGameObject.name + " of type: " + hitCubeObject.type);
                hitCubeObject.CubeAnimation(hitCubeObject.type);
            }
            else
            {
                print("Warning: Either there was no gameObject hit or the Hit gameObject did not have a 'Cube' component!");
            }
        }
    }   
}
