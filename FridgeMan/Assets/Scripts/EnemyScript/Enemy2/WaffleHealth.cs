using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaffleHealth : MonoBehaviour
{
    public AudioSource frostDamage;
    public AudioSource shootDamage;

    public Text WaffleHealthText;
    public Image WaffleHealthBar;

    float health, maxHealth = 80;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("HP: " + health.ToString() + "%");
        WaffleHealthText.text = "HP: " + health.ToString() + "%";
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        WaffleHealthBar.fillAmount = health / maxHealth;
    }


    //private void OnTriggerEnter(Collider collision)

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "PlayerProjectile")
        {
            //Debug.Log("trigger");
            shootDamage.Play();
            health -= 10;
        }
        else if (other.gameObject.tag == "RearProjectile")
        {
            frostDamage.Play();
            health -= 15;
        }

    if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
    }
}
