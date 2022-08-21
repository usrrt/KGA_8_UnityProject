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
        // ����ٰ� �� �������� �����Ѵٸ�?
        // �����¶�� 
        if(doorIsLock)
        {
            Debug.Log("Door is lock");
            // ��Ĭ��Ĭ �Ҹ� �ֱ�
        }
        else
        {
            _ani.SetBool("Open", doorAction);
            // ���� �Ҹ� �ֱ�
        }
        
        
    }
}
