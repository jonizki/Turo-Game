using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public FireBallScript fireballPrefab;
    public float arrowSpeed;
    private float time = 0;
    public float arrowDelay;

    public bool fromLeft = false;
    public bool shoot;

    private Vector2 dir2;


    void Start()
    {
        dir2 = new Vector2(0, arrowSpeed);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot == true)
        {
            if (time < Time.time)
            {
                FireBallScript fireball = Instantiate(fireballPrefab, transform.position, transform.rotation) as FireBallScript;
                fireball.dir = dir2;
                if (fromLeft == true)
                {
                    fireball.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    fireball.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                time = Time.time + arrowDelay;
            }
        }

    }
}
