using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTimer : MonoBehaviour
{
    float whiteDuration = 1;
    float redDuration = 0.5f;
    float timeLeftToSwitchToWhite, timeLeftToSwitchToRed;
    public bool isWhite;
    // Start is called before the first frame update
    void Start()
    {
        isWhite = true;
        timeLeftToSwitchToRed = redDuration;
    }
    void PlayTimer()
    {
        if (timeLeftToSwitchToWhite <= 0)
        {
            timeLeftToSwitchToWhite = redDuration;
            isWhite = true;
        }
        if (timeLeftToSwitchToRed <= 0)
        {
            timeLeftToSwitchToRed = whiteDuration;
            isWhite = false;
        }

        if (isWhite)
        {
            timeLeftToSwitchToRed -= Time.deltaTime;
        }
        else
        {
            timeLeftToSwitchToWhite -= Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        PlayTimer();
    }
}
