using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class Instructions : MonoBehaviour
{
    public void NextButton()// hit instructions button
    {
        SceneManager.LoadScene("Instructions");// loads instructions
    }
}