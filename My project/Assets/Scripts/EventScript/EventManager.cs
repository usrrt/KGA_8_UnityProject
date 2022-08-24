using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singletone<EventManager>
{
    // �����������Խ� ���︲
    public void PhoneRingEvent(AudioSource _audio)
    {
        _audio.Play();
    }

    // �÷��� �ð� ���� 20 ~ 40������� ���� �ӻ��� 
    public void Wispering()
    {
        float num = Random.Range(20f, 50f);
        if (GameManager.Instance.PlayTime >= num)
        {
            Debug.Log("wispering...");
        }
    }

    // ���� ����� ������ ���� ����
    public void HardCloseDoor()
    {
        if(GameManager.Instance.playerHasKey == true)
        {
            Debug.Log("Door close ");
        }
    }

    // 
}
