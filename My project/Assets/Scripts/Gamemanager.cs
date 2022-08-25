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
        // ���� ����ð� üũ�ϱ�
        elapsedTime += Time.deltaTime;
        PlayTime = Mathf.Round(elapsedTime);
    }

}
