using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    void Start()
    {
        // Find all objects of type Light in the scene
        Light[] lights = FindObjectsOfType<Light>();

        // Loop through each light and turn it off
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }

    // Call this function to turn off the lights, 
    // for example from another script or a UI button
  //
  /*public void Update()
    {
        TurnOffAllLights();
        print("here");
    }*/
}
