using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggHealth : MonoBehaviour
{

    public Text EggHealthText;
    public Image EggHealthBar;

    float health, maxHealth = 20;

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("HP: " + health.ToString() + "%");
        EggHealthText.text = "HP: " + health.ToString() + "%";
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        EggHealthBar.fillAmount = health / maxHealth;
    }


    //private void OnTriggerEnter(Collider collision)

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "PlayerProjectile")
        {
            //Debug.Log("trigger");
            //shootDamage.Play();
            health -= 10;
        }
        else if (other.gameObject.tag == "RearProjectile")
        {
            //frostDamage.Play();
            health -= 15;
        }

        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
    }
}
