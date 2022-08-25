using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDrawer : Interactable
{
    public Animator ani;
    public PassWordScript passWord;
    [Header("Ű�е�")]
    public GameObject keyPad;

    private bool doorAction;

    private void FixedUpdate()
    {
        if(passWord.Unlock)
        {
            PromtMessage = "���� ����";
        }
        else
        {
            PromtMessage = "��� ����";

        }
    }

    protected override void Interact()
    {
        // Ű�е� ui ����
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
        Debug.Log("�������� �Ҹ�");
        yield return new WaitForSeconds(0.5f);
    }
}
