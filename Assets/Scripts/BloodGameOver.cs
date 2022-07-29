using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BloodGameOver : MonoBehaviour
{
    public Text bloodUI;
    public Text textUI;
    void Start()
    {
    }

    private void Update()
    {
        updateBloodUI();
    }

    void updateBloodUI()
    {
        bloodUI.text = GameObject.Find("Protagonist").GetComponent<Controller_input>().currentHP.ToString();
        if (!GameObject.Find("Protagonist").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Death") && GameObject.Find("Protagonist").GetComponent<Basic_control>().restart)
        {
            StartCoroutine(showTextFuntion());
            SceneManager.LoadScene("GameplayScene");
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
