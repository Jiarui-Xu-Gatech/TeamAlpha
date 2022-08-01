using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        this.gameObject.active = false;
    }

    public void SwitchDisplay()
    {
        if (this.gameObject.active)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
