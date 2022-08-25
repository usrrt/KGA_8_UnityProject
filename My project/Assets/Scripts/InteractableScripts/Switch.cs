using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interactable
{
    [SerializeField] Light light;

    void Start()
    {
        light.enabled = false;
        PromtMessage = "����ġ [E]";
    }

    protected override void Interact()
    {
        LightButton();
    }

    private void LightButton()
    {
        light.enabled = !light.enabled;
        Debug.Log("����ġ �Ҹ�");
    }
}
