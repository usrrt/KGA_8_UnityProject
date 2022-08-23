using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Door : Interactable
{
    [SerializeField]
    private Animator _ani;   
    public bool doorIsLock;
    private bool doorAction;

    

    private void Start()
    {
        WinePuzzle.Unlock += OpenPuzzleDoor;
    }

    protected override void Interact()
    {
        
        // �±װ� Lock�Ͻ� doorIsLock = true;
        if(gameObject.tag == "LockDoor")
        {
            doorIsLock = !GameManager.Instance.playerHasKey;

            if(doorIsLock)
            {
                PromtMessage = "����ִ�.";
                Debug.Log("��Ĭ�Ÿ��� �Ҹ�");
            }
            else
            {
                PromtMessage = "[E]";
                StartCoroutine(DoorAction());
            }

        }
        else if (gameObject.CompareTag("LockDoor_Wine"))
        {
            PromtMessage = "������ ����.";
        }
        else
        {
            StartCoroutine(DoorAction());
        }

    }

    public void OpenPuzzleDoor()
    {
        // tag = LockDoor_Wine�� ���� ����ȴ�.
        if(gameObject.transform.CompareTag("LockDoor_Wine"))
        {
            _ani.SetBool("Open", true);
            Debug.Log("�������� �Ҹ�");
        }
    }


    // ���� �������� �Է¹޾� �����°� ����
    IEnumerator DoorAction()
    {
        doorAction = !doorAction;
        _ani.SetBool("Open", doorAction);
        Debug.Log("�������� �Ҹ�");
        yield return new WaitForSeconds(0.5f);
    }


}
