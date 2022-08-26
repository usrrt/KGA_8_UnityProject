using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartLightOff : MonoBehaviour
{
    [SerializeField]
    private GameObject lights;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < SoundManager.Instance.sounds.Length; i++)
            {
                if (SoundManager.Instance.sounds[i].soundName == "StartSound")
                {
                    _audio.clip = SoundManager.Instance.sounds[i].AudioClip;
                }
            }

            _audio.PlayOneShot(_audio.clip);
            lights.SetActive(false);
        }
    }
}
