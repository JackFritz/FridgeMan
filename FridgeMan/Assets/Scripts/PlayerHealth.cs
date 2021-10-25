using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
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
        healthText.text = "HP: " + health + "%";
        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
