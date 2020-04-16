using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSoundScript : MonoBehaviour
{

    public GameObject mysound;


    void Start()
    {
        mysound = GameObject.Find("GameSound");
        Destroy(mysound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
