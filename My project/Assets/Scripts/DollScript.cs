using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollScript : Interactable
{
    private void LateUpdate()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            PromtMessage = "Į�� ���";
        }
        else
        {
            PromtMessage = "ã�Ҵ�!";
        }
    }
    protected override void Interact()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            // Į������
            Debug.Log("3�� �");

        }
        else
        {
            // Į������
            Debug.Log("Į�� ���� �� �׾�����ž�");
        }
    }
}
