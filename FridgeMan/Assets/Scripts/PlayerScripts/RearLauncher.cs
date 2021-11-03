using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearLauncher : MonoBehaviour
{
    float timer;

    [SerializeField]
    private Transform[] firePoints;

    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 300f;

    private void Start()
    {
        timer = 1f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.L) && timer <= 0)
        {
            LaunchProjectile();
            timer = 2f;
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
