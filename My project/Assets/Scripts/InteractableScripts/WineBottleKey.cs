using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineBottleKey : Interactable
{
    private void Start()
    {
        PromtMessage = "���κ� [E]";
    }

    protected override void Interact()
    {
        GameManager.Instance.playerHasWine = true;
        gameObject.SetActive(false);

    }
}
