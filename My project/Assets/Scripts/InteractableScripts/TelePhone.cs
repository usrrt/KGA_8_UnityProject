using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePhone : Interactable
{
    private void Start()
    {
        // 전화벨소리 끄기   
    }

    private void LateUpdate()
    {
        // 이벤트 발생후 몇초뒤에 전화벨소리 울리게함
    }

    protected override void Interact()
    {
        // 상호작용시 해야할 것들
        // 1. 벨소리 멈춤
        // 2. 힌트 UI띄울것
    }
}
