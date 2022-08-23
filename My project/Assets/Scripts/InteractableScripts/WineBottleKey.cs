using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineBottleKey : Interactable
{
    private void Start()
    {
        PromtMessage = "øÕ¿Œ∫¥ [E]";
    }

    protected override void Interact()
    {
        GameManager.Instance.playerHasWine = true;
        gameObject.SetActive(false);

    }
}
