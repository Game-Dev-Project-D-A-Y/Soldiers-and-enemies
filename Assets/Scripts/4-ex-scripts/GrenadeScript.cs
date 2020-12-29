using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*   Grenade Script that makes explode and destory all enemies around
*/
public class GrenadeScript : MonoBehaviour
{
    [Tooltip("Explosion effect")]
    [SerializeField] GameObject explosionEffect;
    [Tooltip("Grenade delay before exploding")]
    [SerializeField] float delay = 3f;
    [Tooltip("Hit radius")]
    [SerializeField] float radius = 20f;

    private float startingTime;
    // Start is called before the first frame update
    void Start()
    {
        startingTime = Time.deltaTime;
    }

    void Update()
    {
        startingTime += Time.deltaTime;
        if(startingTime >= delay)
        {
            Explode();
        }
    }

    private void Explode()
    {
        // get all colliders in given radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider near in colliders)
        {
            // destroy all enemies around
            if(near.tag == "Enemy") {
                Debug.Log(near.name+" is DEAD!");
                Destroy(near.gameObject);
            }
        }
        // create explode effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        // destroy the grenade
        Destroy(gameObject);
    }
}
