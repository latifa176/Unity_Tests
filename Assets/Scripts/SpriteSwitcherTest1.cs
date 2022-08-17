using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcherTest1 : MonoBehaviour
{
    SpriteTimer spriteTimer;

    // Start is called before the first frame update
    void Start()
    {
        spriteTimer = FindObjectOfType<SpriteTimer>();

    }
    void UpdateSprite()
    {
        if (spriteTimer.isWhite)
        {

        }
        else
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        UpdateSprite();
    }
}
