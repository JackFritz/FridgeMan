using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Transform[] firePoints;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 300f;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            LaunchProjectile();
        }
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
    }
}
