using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class StartGame : MonoBehaviour
{
    public void NextButton()// hit start game button
    {
        SceneManager.LoadScene("GridBattle");// loads game
    }
}