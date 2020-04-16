using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindLastObject : MonoBehaviour
{

    public GameObject lastsound;


    void Start()
    {
        lastsound = GameObject.Find("ThirdMusic");
        Destroy(lastsound);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
