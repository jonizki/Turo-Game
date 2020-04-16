using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTransition : MonoBehaviour
{

    private static ThirdTransition instance;

    private void Awake()
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