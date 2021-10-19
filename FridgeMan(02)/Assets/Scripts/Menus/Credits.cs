using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class Credits : MonoBehaviour
{
    public void NextButton()// give the credits button a good slap
    {
        SceneManager.LoadScene("Credits");// loads credits... hey that's us!
    }
}