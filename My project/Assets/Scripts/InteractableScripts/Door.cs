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
        PassWordScript.CloseDoorEvent += ClosePuzzleDoor;

        PromtMessage = "[E]";
    }

    protected override void Interact()
    {
        if(gameObject.tag == "NeverOpen")
        {
            PromtMessage = "������ �ʴ´�.";
            SoundManager.Instance.LockDoorSound();
        }

        if(gameObject.tag == "LockDoor")
        {
            doorIsLock = !GameManager.Instance.playerHasKey;

            if(doorIsLock)
            {
                PromtMessage = "����ִ�.";
                SoundManager.Instance.LockDoorSound();

            }
            else
            {
                PromtMessage = "[E]";
                SoundManager.Instance.DoorUnlockSound();
                StartCoroutine(DoorAction());
            }

        }

        if (gameObject.CompareTag("LockDoor_Wine"))
        {
            PromtMessage = "������ ����.";
        }
        
        if (gameObject.CompareTag("Door") || gameObject.CompareTag("Closet") || gameObject.CompareTag("Drawer"))
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
            SoundManager.Instance.DoorOpenSound();
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

    IEnumerator DoorAction()
    {
        doorAction = !doorAction;
        if(gameObject.CompareTag("Door"))
        {
            if (doorAction)
            {
                SoundManager.Instance.DoorOpenSound();
            }
            else
            {
                SoundManager.Instance.DoorCloseSound();
            }
        }
        if (gameObject.CompareTag("Closet"))
        {
            SoundManager.Instance.ClosetSounds();
        }
        if (gameObject.CompareTag("Drawer"))
        {
            SoundManager.Instance.DrawerSounds();
        }
        yield return new WaitForSeconds(0.2f);
        _ani.SetBool("Open", doorAction);
    }


}
