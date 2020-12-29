using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*   Script that switching the lights with given key
*/
public class TurnLightScript : MonoBehaviour{
    
    [SerializeField] KeyCode keyToSwitch;
    [SerializeField] GameObject light;
    private bool isOn = false;

    void Start()
    {
        if(keyToSwitch == KeyCode.None)
        {
            keyToSwitch = KeyCode.E;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(keyToSwitch) && !isOn)
        {
            light.SetActive(true);
            isOn = true;
        }
        else if (other.tag == "Player" && Input.GetKeyDown(keyToSwitch) && isOn)
        {
            light.SetActive(false);
            isOn = false;
        }
    }
}
