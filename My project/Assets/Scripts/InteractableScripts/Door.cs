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
            PromtMessage = "열리지 않는다.";
            Debug.Log("찰칵거리는 소리");
        }
        // 태그가 Lock일시 doorIsLock = true;
        if(gameObject.tag == "LockDoor")
        {
            doorIsLock = !GameManager.Instance.playerHasKey;

            if(doorIsLock)
            {
                PromtMessage = "잠겨있다.";
                Debug.Log("찰칵거리는 소리");
            }
            else
            {
                PromtMessage = "[E]";
                StartCoroutine(DoorAction());
            }

        }
        else if (gameObject.CompareTag("LockDoor_Wine"))
        {
            PromtMessage = "문고리가 없다.";
        }
        else
        {
            StartCoroutine(DoorAction());
        }

    }

    public void OpenPuzzleDoor()
    {
        // tag = LockDoor_Wine인 문을 열면된다.
        if(gameObject.transform.CompareTag("LockDoor_Wine"))
        {
            _ani.SetBool("Open", true);
            Debug.Log("문열리는 소리");
        }
    }

    // 비밀번호를 풀었을때 실행한다.
    public void ClosePuzzleDoor()
    {
        if (gameObject.transform.CompareTag("LockDoor_Wine"))
        {
            _ani.SetBool("Open", false);
            audio.PlayOneShot(clip);
        }
    }


    // 문이 연속으로 입력받아 닫히는것 방지
    IEnumerator DoorAction()
    {
        doorAction = !doorAction;
        _ani.SetBool("Open", doorAction);
        Debug.Log("문열리는 소리");
        yield return new WaitForSeconds(0.5f);
    }


}
