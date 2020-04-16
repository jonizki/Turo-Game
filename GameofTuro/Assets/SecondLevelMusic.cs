using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelMusic : MonoBehaviour
{

    private static SecondLevelMusic instance;

    void Awake()
    {
        if (instance == null)
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
