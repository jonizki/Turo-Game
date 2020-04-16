using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
