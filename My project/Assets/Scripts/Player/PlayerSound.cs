using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public delegate void SoundFuns();
    public static event SoundFuns playSound;
    
    private AudioSource _playerAudio;
    private PlayerInput _input;

    public AudioClip stepSound;

    private void Awake()
    {
        _playerAudio = GetComponent<AudioSource>();  
        _input = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        _playerAudio.clip = stepSound;
    }
    bool IsWalking;
    private void Update()
    {
        FootStepSound();

    }

    float elapsedTime;
    private void FootStepSound()
    {
        if (_input.xPos != 0 || _input.zPos != 0)
            IsWalking = true;
        else
            IsWalking = false;

        if (IsWalking)
        {
            if (_playerAudio.isPlaying)
                return;
            
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= 0.7f)
            {
                _playerAudio.Play();
                elapsedTime = 0f;
            }
        }
        else
        {
            _playerAudio.Stop();
        }
    }
}
