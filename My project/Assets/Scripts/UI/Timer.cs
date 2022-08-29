using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI _timerText;

    public string TimeText;

    private int miniute;
    private int hour;

    private void Awake()
    {
        _timerText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        hour = 3;
        miniute = 0;
        TimeCalculate();
    }

    private void TimeCalculate()
    {
        StartCoroutine(delayTime());
    }

    IEnumerator delayTime()
    {
        while (true)
        {
           if(miniute == 60)
            {
                hour++;
                miniute = 0;
            }
            _timerText.text = String.Format("{0:D2} : {1:D2}",hour, miniute);
            yield return new WaitForSeconds(2f);
            miniute++;
            if (hour == 5)
            {
                Debug.Log("Time out");
                yield return new WaitForSeconds(1f);
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
