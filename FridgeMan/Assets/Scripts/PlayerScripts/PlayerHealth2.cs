using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth2 : MonoBehaviour
{
    public AudioSource damageSound;

    public Text healthText;
    public Image healthBar;

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
        healthText.text = "HP: " + health.ToString() + "%";
        HealthBarFiller();

    }

    void HealthBarFiller()
    {
        healthBar.fillAmount = health / maxHealth;
    }


    //private void OnTriggerEnter(Collider collision)

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("trigger");
            damageSound.Play();
            health -= 5;
        }

        else if (other.gameObject.tag == "HeavyDamage")
        {
            Debug.Log("trigger");
            damageSound.Play();
            health -= 15;
        }



        if (health <= 0)
        {
            SceneManager.LoadScene("FoodKingdom");
        }
    }
}
