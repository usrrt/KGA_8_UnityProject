using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singletone<EventManager>
{
    float PlayTimer;

    public float RandomTime;
    private void Start()
    {
        RandomTime = Random.Range(20f, 50f);
        Debug.Log(RandomTime);
    }
    private void Update()
    {
        PlayTimer += Time.deltaTime;

    }

    // �����������Խ� ���︲
    public void PhoneRingEvent(AudioSource _audio)
    {
        _audio.Play();
    }

    // �÷��� �ð� ���� 20 ~ 40������� ���� �ӻ��� 
    public void Wispering(AudioSource _audio)
    {
        if (PlayTimer >= RandomTime)
        {
            Debug.Log("wisper");
            int random = Random.Range(0, 2);
            Debug.Log(random);
            RandomTime = Random.Range(60f, 100f);
            _audio.PlayOneShot(SoundManager.Instance.sounds[random].AudioClip);
            PlayTimer = 0;
        }
    }

    
}
