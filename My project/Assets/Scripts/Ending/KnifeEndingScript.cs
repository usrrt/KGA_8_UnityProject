using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KnifeEndingScript : MonoBehaviour
{
    private TextMeshProUGUI _typingText;

    private string _message;

    private void Awake()
    {
        _typingText = GetComponentInChildren<TextMeshProUGUI>();
    }
    void Start()
    {
        _message = @"난 귀여운 제리 인형을 향해 칼을 휘둘렀다

그리고 잠시후 다락방안에서 미친듯이 소리를 지르며 칼을 휘두르는 자신을 발견할수있었다.

난 집안에서 느껴지는 음산한 시선이 느껴지는것 같아 곧바로 집밖으로 뛰쳐나왔다...";

        StartCoroutine(Typing());
    }

    IEnumerator Typing()
    {

        for (int i = 0; i < _message.Length; i++)
        {
            _typingText.text = _message.Substring(0, i + 1);
            yield return new WaitForSeconds(.1f);
        }
        SceneManager.LoadScene("TitleScene");

    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
