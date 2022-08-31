using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhonRingEvent : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            audio.Play();
            GameManager.Instance.playerHasLight = false;
        }
    }
}
