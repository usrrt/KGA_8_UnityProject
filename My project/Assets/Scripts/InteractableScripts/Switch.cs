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
        PromtMessage = "스위치 [E]";
    }

    protected override void Interact()
    {
        LightButton();
    }

    private void LightButton()
    {
        light.enabled = !light.enabled;
        Debug.Log("스위치 소리");
    }
}
