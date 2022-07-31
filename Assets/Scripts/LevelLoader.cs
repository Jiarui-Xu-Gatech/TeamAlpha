using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public int iLevelToLoad;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider others)
    {
        if (others.name == "Protagonist")
        {
            if (GameObject.Find("Protagonist").GetComponent<BallCollecter>().ballgathered == 3)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(iLevelToLoad);
            }
        }
    }
}