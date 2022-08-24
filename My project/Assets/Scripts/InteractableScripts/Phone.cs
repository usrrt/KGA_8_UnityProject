using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Interactable
{
    AudioSource _audio;
    //public AudioClip _audioClip;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PromtMessage = "��ȭ �ޱ� [E]";
    }
    
    protected override void Interact()
    {
        _audio.Stop();
    }
}
