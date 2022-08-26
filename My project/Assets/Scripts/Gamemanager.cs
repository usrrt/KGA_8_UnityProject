using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singletone<GameManager>
{
    public float lookSensitivity = 3f; // 마우스 감도

    public bool playerHasLight;

    public bool playerHasKey;

    public bool playerHasWine;

    public bool playerHasKnife;

    public bool KeyPadActivated;

    private void Start()
    {
        playerHasLight = false;
        playerHasKey = false;
        playerHasKey = false;
        playerHasKnife = false;
        KeyPadActivated = false;
    }

}
