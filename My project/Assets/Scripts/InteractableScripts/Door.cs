using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Door : Interactable
{
    [SerializeField]
    private Animator _ani;   

    public AudioClip clip;
    public AudioSource audio;

    public bool doorIsLock;
    private bool doorAction;


    private void Start()
    {
        WinePuzzle.Unlock += OpenPuzzleDoor;
        PassWordScript.Pass += ClosePuzzleDoor;
    }

    protected override void Interact()
    {
        if(gameObject.tag == "NeverOpen")
        {
            PromtMessage = "������ �ʴ´�.";
            Debug.Log("��Ĭ�Ÿ��� �Ҹ�");
        }
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

    // ��й�ȣ�� Ǯ������ �����Ѵ�.
    public void ClosePuzzleDoor()
    {
        if (gameObject.transform.CompareTag("LockDoor_Wine"))
        {
            _ani.SetBool("Open", false);
            audio.PlayOneShot(clip);
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
