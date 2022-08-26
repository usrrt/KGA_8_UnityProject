using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip AudioClip;
}
public class SoundManager : Singletone<SoundManager>
{
    public Sound[] sounds;

    public AudioSource audio;

    private void Start()
    {
        
    }
}
