using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vspread : MonoBehaviour
{
    [SerializeField]
    private Transform[] firePoints;

    [SerializeField]
    private Rigidbody projectilePrefab;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
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
        }
    }
}
