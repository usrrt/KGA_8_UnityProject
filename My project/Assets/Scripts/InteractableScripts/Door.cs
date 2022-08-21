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
        doorAction = !doorAction;
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
            _ani.SetBool("Open", doorAction);
            // 끼익 소리 넣기
        }
        
        
    }
}
