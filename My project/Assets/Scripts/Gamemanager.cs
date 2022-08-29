using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singletone<GameManager>
{
    public float lookSensitivity = 3f; // ���콺 ����

    public bool playerHasLight;

    public bool playerHasKey;

    public bool playerHasWine;

    public bool playerHasKnife;

    public bool KeyPadActivated;

    public bool TimeOutEnding;
    public bool DeathEnding;
    public bool KnifeEnding;

    private void Start()
    {
        playerHasLight = false;
        playerHasKey = false;
        playerHasKey = false;
        playerHasKnife = false;
        KeyPadActivated = false;
        TimeOutEnding = false;
        DeathEnding = false;
        KnifeEnding = false;
    }

}
