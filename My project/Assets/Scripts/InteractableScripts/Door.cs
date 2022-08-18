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
        // ����ٰ� �� �������� �����Ѵٸ�?
        doorOpen = !doorOpen;
        _ani.SetBool("Open", doorOpen);
        
    }
}
