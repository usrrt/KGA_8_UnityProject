using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DieEnable : MonoBehaviour
{
    Image _image;
    TextMeshProUGUI _dieText;

    float _alphaCount;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _dieText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        _alphaCount = 0;
        _image.color = new Color(0, 0, 0, _alphaCount);
        _dieText.color = new Color(1, 1, 1, _alphaCount);
        
    }

    private void OnEnable()
    {
        
        StartCoroutine(fadeInEffect());
    }
    float elapsedTime;
    IEnumerator fadeInEffect()
    {
        //SoundManager.Instance.DeathSound();
        while (elapsedTime < 6.5f)
        {
            Debug.Log(elapsedTime);
            elapsedTime += Time.deltaTime;
            yield return new WaitForSeconds(.02f);
            _image.color = new Color(0, 0, 0, _alphaCount);
            _dieText.color = new Color(1, 1, 1, _alphaCount);
            _alphaCount += 0.01f;

        }
        GameManager.Instance.Init();
        SceneManager.LoadScene("TitleScene");
    }
}
