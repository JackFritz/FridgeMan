using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PancakeBoss : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PancakeBoss")
        {
            SceneManager.LoadScene("GridBoss");
        }
    }
}