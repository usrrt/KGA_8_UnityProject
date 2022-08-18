using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string PromtMessage;

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        // �ƹ��ڵ峪 �� �޼ҵ�ȿ� �����ִ�
        // ����Ŭ���� �������̵带 ���� ���ø�
    }
}
