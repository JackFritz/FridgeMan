using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss2Health : MonoBehaviour
{
    //public AudioSource spitDamage;
    //public AudioSource frostDamage;

    public Text BossHealthText;
    public Image BossHealthBar;

    float health, maxHealth = 200;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("HP: " + health.ToString() + "%");
        BossHealthText.text = "HP: " + health.ToString() + "%";
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        BossHealthBar.fillAmount = health / maxHealth;
    }


    //private void OnTriggerEnter(Collider collision)

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "PlayerProjectile")
        {
            //Debug.Log("trigger");
            //spitDamage.Play();
            health -= 10;
        }
        else if (other.gameObject.tag == "RearProjectile")
        {
            //frostDamage.Play();
            health -= 25;
        }


        if (health <= 0)
        {
            //You can change what scene the game trasitions to below
            //SceneManager.LoadScene("PKBossDefeated");
        }
    }
}
