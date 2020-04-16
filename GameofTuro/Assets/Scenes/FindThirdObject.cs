using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindThirdObject : MonoBehaviour
{

    public GameObject mysound;


    void Start()
    {
        mysound = GameObject.Find("SecondSound");
        Destroy(mysound);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
