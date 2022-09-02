using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip audioClip;

    
}
public class SoundManager : Singletone<SoundManager>
{
    private AudioSource m_AudioSource;

    [Header("BGM Audio")]
    public AudioSource _audioBGM;

    public Sound[] sounds;

    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();

        _audioBGM = gameObject.AddComponent<AudioSource>();
    }

    private void Start()
    {
       BackGroundSound();
    }

    public void BackGroundSound()
    {
        _audioBGM.loop = true;
        _audioBGM.playOnAwake = true;
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "StormSound")
            {
                _audioBGM.clip = sounds[i].audioClip;
            }
        }
        _audioBGM.volume = 0.2f;
        _audioBGM.Play();   
    }

    public void GameStartSound()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "StartSound")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 0.2f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void WisperSound()
    {
        int randomWisperClip = Random.Range(0, 2);
        m_AudioSource.PlayOneShot(sounds[randomWisperClip].audioClip);
    }

    public void DoorOpenSound()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "DoorOpen")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void LockDoorSound()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "LockDoorSound")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void DoorCloseSound()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "DoorClose")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void DoorUnlockSound()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "DoorUnlock")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void DrawerSounds()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "DrawerSound")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void ClosetSounds()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "ClosetSound")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    public void DeathSound()
    {
        _audioBGM.Stop();
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == "DeathSound")
            {
                m_AudioSource.clip = sounds[i].audioClip;
            }
        }
        m_AudioSource.volume = 1f;
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
        
    }
}
