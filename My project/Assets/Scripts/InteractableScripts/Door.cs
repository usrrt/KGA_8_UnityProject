using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : Interactable
{
    [SerializeField]
    private Animator _ani;
    
    public bool doorIsLock;

    private bool doorAction;

    protected override void Interact()
    {
        Debug.Log("check");
        // 태그가 Lock일시 doorIsLock = true;
        if(gameObject.tag == "LockDoor")
        {
            doorIsLock = !GameManager.Instance.playerHasKey;
            // 여기다가 문 움직임을 구현한다면?
            // 잠긴상태라면 
            if(doorIsLock)
            {
                Debug.Log("Door is lock");
                // 찰칵찰칵 소리 넣기
            }
            else
            {
                StartCoroutine(DoorAction());
                // 끼익 소리 넣기
            }

        }
        else
        {
            StartCoroutine(DoorAction());
            // 끼익 소리 넣기
        }

        // 문이 연속으로 입력받아 닫히는것 방지
        IEnumerator DoorAction()
        {
            doorAction = !doorAction;
            _ani.SetBool("Open", doorAction);
            yield return new WaitForSeconds(0.5f);
        }

    }

}
