using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Interactable
{
    protected override void Interact()
    {
        Debug.Log("상호작용: " + gameObject.name);
    }
}
