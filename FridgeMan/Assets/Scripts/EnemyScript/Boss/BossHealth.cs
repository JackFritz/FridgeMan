using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    //public AudioSource ;
   // public AudioSource ;

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
            // .Play();
            health -= 8;
        }
        else if (other.gameObject.tag == "RearProjectile")
        {
            // .Play();
            health -= 30;
        }


        if (health <= 0)
        {
            SceneManager.LoadScene("PancakeParadise");
        }
    }
}
