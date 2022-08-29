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

    // 지정구역진입시 폰울림
    public void PhoneRingEvent(AudioSource _audio)
    {
        _audio.Play();
    }

    // 플레이 시간 랜덤 20 ~ 40초진행시 랜덤 속삭임 
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
