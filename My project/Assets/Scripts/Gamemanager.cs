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

    public float elapsedTime;
    public float PlayTime;
    private void Update()
    {
        // 게임 진행시간 체크하기
        elapsedTime += Time.deltaTime;
        PlayTime = Mathf.Round(elapsedTime);
    }

}
