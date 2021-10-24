using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class IntroCut : MonoBehaviour
{
    public void NextButton()// hit start game button
    {
        SceneManager.LoadScene("IntroCutPart1");// loads game
    }
}