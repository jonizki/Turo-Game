using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthLevelMusic : MonoBehaviour
{

    private static FourthLevelMusic instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}