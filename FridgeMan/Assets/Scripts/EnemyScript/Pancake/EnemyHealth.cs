using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public AudioSource frostDamage;
    public AudioSource shootDamage;

    public Text PancakeHealthText;
    public Image PancakeHealthBar;

    float health, maxHealth = 100;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("HP: " + health.ToString() + "%");
        PancakeHealthText.text = "HP: " + health.ToString() + "%";
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        PancakeHealthBar.fillAmount = health / maxHealth;
    }


    //private void OnTriggerEnter(Collider collision)

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "PlayerProjectile")
        {
            //Debug.Log("trigger");
            shootDamage.Play();
            health -= 5;
        }
        else if (other.gameObject.tag == "RearProjectile")
        {
            frostDamage.Play();
            health -= 15;
        }


        if (health <= 0)
        {
            SceneManager.LoadScene("FirstAbility");
        }
    }
}
