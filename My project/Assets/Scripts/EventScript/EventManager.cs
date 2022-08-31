using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singletone<EventManager>
{
    float PlayTimer;

    public float RandomTime;
    private void Start()
    {
        RandomTime = Random.Range(60f, 100f);
        Debug.Log(RandomTime);
    }
    private void Update()
    {
        Wispering();
    }

    public void Wispering()
    {
        PlayTimer += Time.deltaTime;
        if (PlayTimer >= RandomTime)
        {
            SoundManager.Instance.WisperSound();
            RandomTime = Random.Range(60f, 100f);
            PlayTimer = 0;
        }
    }

    
}
