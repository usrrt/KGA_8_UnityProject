using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDrawer : Interactable
{
    public Animator ani;
    public PassWordScript passWord;
    [Header("키패드")]
    public GameObject keyPad;

    private bool doorAction;

    private void FixedUpdate()
    {
        if(passWord.Unlock)
        {
            PromtMessage = "열린 서랍";
        }
        else
        {
            PromtMessage = "잠긴 서랍";

        }
    }

    protected override void Interact()
    {
        // 키패드 ui 띄우기
        if(passWord.Unlock)
        {
            StartCoroutine(DoorAction());
        }
        else
        {
            passWord.CheckNumber();
        }
    }

    IEnumerator DoorAction()
    {
        doorAction = !doorAction;
        ani.SetBool("Open", doorAction);
        Debug.Log("문열리는 소리");
        yield return new WaitForSeconds(0.5f);
    }
}
