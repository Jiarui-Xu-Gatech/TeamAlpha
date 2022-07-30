using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    

    public AudioSource audioS;
    //public AudioClip audioC;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x!=position.x||this.transform.position.z != position.z) 
        {
            audioS.mute = false;
            //audioS.PlayOneShot(audioC);
            position.x = this.transform.position.x;
            position.y = this.transform.position.y;
            position.z = this.transform.position.z;

        }
        else
        {
            audioS.mute=true;
        }
    }

    //public void AudioPlay(AudioClip clip)
    //{
    //    audioS.PlayOneShot(clip);
    //}
}
