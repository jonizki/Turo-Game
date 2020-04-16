using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTransitionSounds : MonoBehaviour
{

    private static NewTransitionSounds instance;

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
