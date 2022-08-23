using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightItem : Interactable
{
   
    protected override void Interact()
    {

        Debug.Log(gameObject.name + " ȹ��");
        GameManager.Instance.playerHasLight = true;
        Destroy(gameObject);
    }
}
