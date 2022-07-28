using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BloodGameOver : MonoBehaviour
{
    private int currentBlood;
    public Text bloodUI;
    public Text textUI;
    void Start()
    {
        currentBlood = int.Parse(bloodUI.text);
    }

    private void Update()
    {
        currentBlood = int.Parse(bloodUI.text);
        updateBloodUI();
    }

    void updateBloodUI()
    {
        if (currentBlood > 0)
        {
            bloodUI.text = currentBlood.ToString();
        }
        else
        {
            //timeUI.text = "Game Over!";
            StartCoroutine(showTextFuntion());
            SceneManager.LoadScene("SampleScene");
        }

    }
    IEnumerator showTextFuntion()
    {
        textUI.text = "Game Over!";
        yield return new WaitForSeconds(5);
        /**TextUI.text = ("The highest number you can pick is " + max);
        yield return new WaitForSeconds(3f);
        TextUI.text = ("The lowest number you can pick is " + min);**/
    }
}
