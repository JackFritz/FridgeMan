using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconAtk : MonoBehaviour
{
    // public Animator

    [SerializeField]
    private Transform[] firePoints;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 300f;


    void Start()
    {
        LaunchProjectile();
        InvokeRepeating("LaunchProjectile", 1f, 1f);
    }

    public void Update()
    {

    }

    private void LaunchProjectile()
    {

        foreach (var firePoint in firePoints)
        {
            var projectileInstance = Instantiate(
            projectilePrefab,
                firePoint.position,
                firePoint.rotation);

            projectileInstance.AddForce(firePoint.forward * launchForce);
        }
        // .SetTrigger("");

    }
}