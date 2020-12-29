using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGrenade : MonoBehaviour
{
    [Tooltip("Position to throw from")]
    [SerializeField] Transform spawnPoint;

    [Tooltip("Grenade prefab")]
    [SerializeField] GameObject grenade;

    [Tooltip("Throw range")]
    [SerializeField] float range = 10f;

    [SerializeField] KeyCode keyToLaunch;

    void Update()
    {
        if(Input.GetKeyDown(keyToLaunch))
        {
            Launch();
        }
    }

    private void Launch()
    {
        // create new grenade object and throw it
        GameObject grenadeInstance = Instantiate(grenade, spawnPoint.position, spawnPoint.rotation);
        grenadeInstance.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
    }
}
