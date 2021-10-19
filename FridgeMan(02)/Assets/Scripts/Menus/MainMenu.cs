using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class MainMenu : MonoBehaviour
{
    public void NextButton()// press main menu button
    {
        SceneManager.LoadScene("MainMenu");// loads main menu
    }
}