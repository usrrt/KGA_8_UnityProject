using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singletone<GameManager>
{
    public float lookSensitivity = 3f; // 마우스 감도

    public bool playerHasLight;

    public bool playerHasKey;

    private void Start()
    {
        playerHasLight = false;
        playerHasKey = false;
    }
}
