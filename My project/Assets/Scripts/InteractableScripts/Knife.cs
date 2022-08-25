using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Interactable
{
    private void Start()
    {
        PromtMessage = "Ä® ÁÝ±â [E]";
    }
    protected override void Interact()
    {
        Debug.Log("Knife");
        GameManager.Instance.playerHasKnife = true;
        gameObject.SetActive(false);
    }
}
