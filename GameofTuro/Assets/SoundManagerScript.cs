using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip jumpSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jumpSound");


        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playsound (string clip)
    {
        switch (clip)
        {
            case "jumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
        }
    }

}
