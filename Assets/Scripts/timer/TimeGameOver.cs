using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeGameOver : MonoBehaviour
{
    public int currentTime=300;
    public Text timeUI;
    void Start()
    {
        
        countDownTimer();
        currentTime = 300;
    }

    void countDownTimer()
    {



        if (currentTime > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(currentTime);
            timeUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            currentTime--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            //timeUI.text = "Game Over!";
            StartCoroutine(showTextFuntion());
            SceneManager.LoadScene("GameOver");
        }

    }
    IEnumerator showTextFuntion()
    {
        timeUI.text = "Game Over!";
        yield return new WaitForSeconds(5);
        /**TextUI.text = ("The highest number you can pick is " + max);
        yield return new WaitForSeconds(3f);
        TextUI.text = ("The lowest number you can pick is " + min);**/
    }
}


 /**   public class TimeGameOver : MonoBehaviour
{
    float currentTime;
    public Text timeUI;
    //bool timeActive = false;
    bool timeActive = true;
    //public int startMinutes;
    // Start is called before the first frame update
    void Start()
    {
        //currentTime = startMinutes * 60;
        currentTime = 0;
        //countDownTimer();
    }

    // Update is called once per frame
    /**void countDownTimer()
    {

        
        if (currentTime > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(currentTime);
            timeUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            currentTime--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timeActive = false;
            timeUI.text = "Game Over!";
        }


    }
    void update()
    {
        if (timeActive == true)
        {
            //countDownTimer();
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan spanTime = TimeSpan.FromSeconds(currentTime);
        timeUI.text = spanTime.ToString(@"mm\:ss\:fff");
        //timeUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds + ":"+ spanTime.Milliseconds;
       //currentTimeText.text = currentTime.ToString();
    }
    public void StartTime()
    {
        timeActive = true;
    }
    public void StopTime()
    {
        timeActive = false;
    }
}**/
