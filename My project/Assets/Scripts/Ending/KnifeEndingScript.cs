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
        _message = @"�� �Ϳ��� ���� ������ ���� Į�� �ֵѷ���

�׸��� ����� �ٶ���ȿ��� ��ģ���� �Ҹ��� ������ Į�� �ֵθ��� �ڽ��� �߰��Ҽ��־���.

�� ���ȿ��� �������� ������ �ü��� �������°� ���� ��ٷ� �������� ���ĳ��Դ�...";

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
