using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightItem : Interactable
{
    [SerializeField]
    private new PlayerLight light;
    protected override void Interact()
    {
     
        light.hasFlashLight = true;
        gameObject.SetActive(false);

    }
}
