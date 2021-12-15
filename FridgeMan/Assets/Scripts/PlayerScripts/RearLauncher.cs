using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RearLauncher : MonoBehaviour
{
    public Text AmmoText;
    float ammo, maxAmmo = 12;

    public Animator openAttack;
    public AudioSource chill;
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

        ammo = maxAmmo;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.L) && timer <= 0 && ammo >= 0)
        {
            openAttack.SetTrigger("PlayerIsOpening");
            chill.Play();
            LaunchProjectile();
            timer = 2f;

            AmmoText.text = ammo.ToString();
            ammo -= 3;
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
            ammo += 6;
        }
    }
}
