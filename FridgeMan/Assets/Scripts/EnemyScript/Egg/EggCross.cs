using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCross : MonoBehaviour
{
    //the egg is cereal now
    public Animator cerealAttack;

    [SerializeField]
    private Transform[] firePoints;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 100f;


    void Start()
    {
        LaunchProjectile();
        InvokeRepeating("LaunchProjectile", 5f, 4f);
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
         cerealAttack.SetTrigger("CerealAttack");

    }
}
