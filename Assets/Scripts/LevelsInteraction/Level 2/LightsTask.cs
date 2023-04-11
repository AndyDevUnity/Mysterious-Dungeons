using System.Collections.Generic;
using UnityEngine;

public class LightsTask : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private List<Light> Lights = new List<Light>();

    private void Update()
    {
        CheckLights();
    }

    private void CheckLights()
    {
        foreach (var light in Lights)
        {
            if (!light.enabled)
                return;
        }
        _key.SetActive(true);
    }
}
