using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOverScript : MonoBehaviour
{
    float elapsedTime;
    private void Start()
    {
        elapsedTime = 0f;
        Debug.Log("ending sound?");
    }
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);
        if(elapsedTime >= 10f)
        {
            ReturnToTitle();
        }
    }
    public void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
