using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//attach script to an empty game object and then place on button
public class Continue : MonoBehaviour
{
    public void NextButton()
    {
        SceneManager.LoadScene("FoodKingdom");
    }
}