using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findMusicObject : MonoBehaviour
{

    public GameObject secondsound;


    void Start()
    {
        secondsound = GameObject.Find("SecondSound");
        Destroy(secondsound);
    }

    // Update is called once per frame
    void Update()
    {

    }
}