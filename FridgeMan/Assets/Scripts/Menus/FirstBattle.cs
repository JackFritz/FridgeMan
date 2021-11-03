using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstBattle : MonoBehaviour
{
    public void NextButton()
    {
        SceneManager.LoadScene("GridBattle2");
    }
}
