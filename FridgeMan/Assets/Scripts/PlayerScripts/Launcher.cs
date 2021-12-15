using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    public Text AmmoText;
    float ammo, maxAmmo = 20;

    public Animator shoot;
    float Cooldown = 1f;
    float timer;

    [SerializeField]
    private Transform[] firePoints;

    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 300f;

    private void Start()
    {
        timer = Cooldown;

        ammo = maxAmmo;

    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.M) && timer <= 0 && ammo >= 0)
        {
            shoot.SetTrigger("PlayerIsShooting");
            LaunchProjectile();
            timer = 0.5f;

            AmmoText.text = ammo.ToString();
            ammo -= 1;
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

    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Ammo")
        {
            AmmoText.text = ammo.ToString();
            ammo += 5;
        }
    }
}
