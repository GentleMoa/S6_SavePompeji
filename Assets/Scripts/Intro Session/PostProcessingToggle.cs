using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessingToggle : MonoBehaviour
{
    [SerializeField] private GameObject _postProcessingVolume;

    //Public Functions
    public void TogglePostProcessing()
    {
        if (_postProcessingVolume != null && _postProcessingVolume.activeSelf == true)
        {
            _postProcessingVolume.SetActive(false);
        }
        else if (_postProcessingVolume != null && _postProcessingVolume.activeSelf == false)
        {
            _postProcessingVolume.SetActive(true);
        }
    }
}
