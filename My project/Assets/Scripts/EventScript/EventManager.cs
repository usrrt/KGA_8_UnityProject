using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singletone<EventManager>
{
    // 지정구역진입시 폰울림
    public void PhoneRingEvent(AudioSource _audio)
    {
        _audio.Play();
    }

    // 플레이 시간 랜덤 20 ~ 40초진행시 랜덤 속삭임 
    public void Wispering()
    {
        float num = Random.Range(20f, 50f);
        if (GameManager.Instance.PlayTime >= num)
        {
            Debug.Log("wispering...");
        }
    }

    // 열쇠 습득시 퍼즐문이 세게 닫힘
    public void HardCloseDoor()
    {
        if(GameManager.Instance.playerHasKey == true)
        {
            Debug.Log("Door close ");
        }
    }

    // 
}
