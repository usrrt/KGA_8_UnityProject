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
        // 아무코드나 이 메소드안에 쓸수있다
        // 하위클래스 오버라이드를 위한 템플릿
    }
}
