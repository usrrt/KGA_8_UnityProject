using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [Header("��ư����")]
    public TextMeshProUGUI BtnNum;

    [Header("��й�ȣ â")]
    public TextMeshProUGUI PassWard;

    private void Start()
    {
        //_BtnNum = GetComponent<TextMeshProUGUI>();
    }

    public void AddNum()
    {
        // ���â�� �ؽ�Ʈ �������
        PassWard.text += BtnNum.text;
    }

}
