using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactable
{
    protected override void Interact()
    {
        Debug.Log(gameObject.name + " È¹µæ");
        GameManager.Instance.playerHasKey = true;
        gameObject.SetActive(false);
    }
}
