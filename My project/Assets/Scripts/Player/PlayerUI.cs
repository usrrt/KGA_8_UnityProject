using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _promtText;

    public void UpdateText(string promtStr)
    {
        _promtText.text = promtStr;
    }
}
