using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaffleAtk : MonoBehaviour
{
    public Animator waffleAttack;
    [SerializeField]
    private Transform[] firePoints;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 450f;


    void Start()
    {
        LaunchProjectile();
        InvokeRepeating("LaunchProjectile", 7f, 5f);
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
        waffleAttack.SetTrigger("WaffleAttacking");
    }
}
