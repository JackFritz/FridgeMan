using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // if statement that loads the next scene
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("PancakeParadise");
        }

    }
}
