using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    public void ExitGame()
    {
        //Time.timeScale = 0f;
        Application.Quit();
    }
}