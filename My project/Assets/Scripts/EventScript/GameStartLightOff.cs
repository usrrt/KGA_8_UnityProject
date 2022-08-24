using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartLightOff : MonoBehaviour
{
    [SerializeField]
    private GameObject lights;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            lights.SetActive(false);
        }
    }
}
