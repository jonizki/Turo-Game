using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthTransition : MonoBehaviour
{

    private static FourthTransition instance;

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
