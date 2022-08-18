using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField]
    private Animator _ani;

    public bool doorOpen = false;

    private void Awake()
    {
        
    }
    protected override void Interact()
    {
        // 여기다가 문 움직임을 구현한다면?
        doorOpen = !doorOpen;
        _ani.SetBool("Open", doorOpen);
        
    }
}
