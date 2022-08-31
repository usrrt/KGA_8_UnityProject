using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PassWordScript : MonoBehaviour
{
    // 풀었을때 이벤트실행
    public delegate void CloseDoorChain();
    public static event CloseDoorChain Pass;

    [Header("비교할 텍스트")]
    public TextMeshProUGUI PasswordText;
    public GameObject InteractTextUI;

    [Header("비밀번호")]
    public string Answer = "651";
    
    public bool Unlock = false;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        CheckNumber();
    }

    private void CloseKeyPad()
    {
        gameObject.SetActive(false);
        InteractTextUI.SetActive(true);
        Cursor.visible = false;
        GameManager.Instance.KeyPadActivated = false;

    }

    private void OpenKeyPad()
    {
        gameObject.SetActive(true);
        InteractTextUI.SetActive(false);
        Cursor.visible = true;
        GameManager.Instance.KeyPadActivated = true;

    }

    public void CheckNumber()
    {
        OpenKeyPad();
        if (PasswordText.text.Length == 3)
        {
            if (PasswordText.text == Answer)
            {
                PasswordText.text = "**Correct**";
                Unlock = true;
                CloseKeyPad();
                Pass();
                return;

            }
            else
            {
                CloseKeyPad();
                PasswordText.text = "";
            }
        }
    }
}
