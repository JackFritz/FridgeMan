using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vspread : MonoBehaviour
{
    //public Animator vAttack;

    [SerializeField]
    private Transform[] firePoints;

    [SerializeField]
    private Rigidbody projectilePrefab;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //vAttack.setTrigger("");
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
