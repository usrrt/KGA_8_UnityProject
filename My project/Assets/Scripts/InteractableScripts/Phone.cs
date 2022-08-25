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
        PromtMessage = "��ȭ �ޱ� [E]";
    }
    
    protected override void Interact()
    {
        _audio.Stop();
        // �÷��̾� ��ġ y������ -30�̵���Ű��
        TeleportPlayer();
    }

    Vector3 telpoY = new Vector3(0f, 15f, 0f);
    private void TeleportPlayer()
    {
        // ���ο� ��ġ
        Vector3 NewPlayerPosition = player.transform.position - telpoY;

        // ��ġ ������ �ٽ� �÷��̾�� �ѱ��
        player.transform.position = NewPlayerPosition;
    }
}
