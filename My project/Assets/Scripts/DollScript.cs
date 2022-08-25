using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollScript : Interactable
{
    private void LateUpdate()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            PromtMessage = "Ä®·Î Âî¸¥´Ù";
        }
        else
        {
            PromtMessage = "Ã£¾Ò´Ù!";
        }
    }
    protected override void Interact()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            // Ä®¼ÒÁö½Ã
            Debug.Log("3¹ø Âî¸§");

        }
        else
        {
            // Ä®¾øÀ»½Ã
            Debug.Log("Ä®ÀÌ ¾ø¾î ³ª Á×¾î¹ö¸±°Å¾ß");
        }
    }
}
