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
        // �±װ� Lock�Ͻ� doorIsLock = true;
        if(gameObject.tag == "LockDoor")
        {
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
                StartCoroutine(DoorAction());
                // ���� �Ҹ� �ֱ�
            }

        }
        else
        {
            StartCoroutine(DoorAction());
            // ���� �Ҹ� �ֱ�
        }

        // ���� �������� �Է¹޾� �����°� ����
        IEnumerator DoorAction()
        {
            doorAction = !doorAction;
            _ani.SetBool("Open", doorAction);
            yield return new WaitForSeconds(0.5f);
        }

    }

}
