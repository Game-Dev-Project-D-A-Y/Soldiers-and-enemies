using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*   Script that switching the street lights with given key
*/
public class turnStreetLightScript : MonoBehaviour
{

    [SerializeField] KeyCode keyToSwitch = KeyCode.E;

    private GameObject light;
    private GameObject bulb;
    private bool isOn = false;

    void Start()
    {
        light = gameObject.transform.Find("Light").gameObject;
        bulb = gameObject.transform.Find("Bulb").gameObject;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(keyToSwitch) && !isOn)
        {
            light.SetActive(true);
            isOn = true;
            bulb.SetActive(true);
        }
        else if (other.tag == "Player" && Input.GetKeyDown(keyToSwitch) && isOn)
        {
            light.SetActive(false);
            isOn = false;
            bulb.SetActive(false);
        }
    }
}



