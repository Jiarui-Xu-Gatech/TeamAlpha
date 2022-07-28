using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using TimeGameOver;
public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "Times";
    }
    public void ReStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("meun");
       
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
