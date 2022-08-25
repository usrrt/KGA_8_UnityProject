using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Interactable
{
    AudioSource _audio;
    //public AudioClip _audioClip;
    public GameObject player;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PromtMessage = "전화 받기 [E]";
    }
    
    protected override void Interact()
    {
        _audio.Stop();
        // 플레이어 위치 y축으로 -30이동시키기
        TeleportPlayer();
    }

    Vector3 telpoY = new Vector3(0f, 15f, 0f);
    private void TeleportPlayer()
    {
        // 새로운 위치
        Vector3 NewPlayerPosition = player.transform.position - telpoY;

        // 위치 정보를 다시 플레이어에게 넘기기
        player.transform.position = NewPlayerPosition;
    }
}
