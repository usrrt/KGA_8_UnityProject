using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [Header("버튼숫자")]
    public TextMeshProUGUI BtnNum;

    [Header("비밀번호 창")]
    public TextMeshProUGUI PassWard;

    private void Start()
    {
        //_BtnNum = GetComponent<TextMeshProUGUI>();
    }

    public void AddNum()
    {
        // 비번창에 텍스트 집어넣음
        PassWard.text += BtnNum.text;
    }

}
