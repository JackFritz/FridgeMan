using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadFirstAbility : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 5f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
