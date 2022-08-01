using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestarter : MonoBehaviour
{
    // Start is called before the first frame update
    public void gameRestart()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}
