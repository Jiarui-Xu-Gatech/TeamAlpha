using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelSetup : MonoBehaviour
{
    //public Sprite lockSprite;
    public Text levelText;
    private int level = 0;
    private Button button;

    void OnEnable()
    {
        button = GetComponent<Button>();
    }
    public void SetUp(int level, bool isUnlock)
    {
        this.level = level;
        levelText.text = level.ToString();
        if (isUnlock)
        {
            button.enabled = true;
            levelText.gameObject.SetActive(true);
        }
        else
        {
            button.enabled = false;
            levelText.gameObject.SetActive(false);
        }
    }
    public void OnClick()
    {
        if (levelText.text == "2")
        {
            SceneManager.LoadScene("Level2");
        }
        if (levelText.text == "3")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
