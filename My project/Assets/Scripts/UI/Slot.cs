using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Items item; // ȹ���� ������
    public int itemCount; // ȹ���� ������ ����
    public Image itemImage; // ������ �̹���

    [SerializeField]
    private GameObject _tooltip;

    [SerializeField]
    private TextMeshProUGUI _tooltipText;

    private void Awake()
    {
        _tooltip.SetActive(false);
    }

    // �̹��� ���� ����
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    // ������ ȹ��
    public void AddItem(Items _item, int count = 1)
    {
        item = _item;
        itemCount = count;
        itemImage.sprite = item.itemImage; // item.itemImage ���ϰ��� sprite Ÿ���� �ؼ��Ұ�
        

        SetColor(1);
    }

    // ���԰��� ����
    public void SetSlotCount(int _count)
    {
        itemCount += _count;

        if (itemCount <= 0)
        {
            clearslot();
        }
    }

    // ������ Ŭ����
    private void clearslot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        if(item != null)
        {
            // ������ ������ ���� UI �ѱ�
            _tooltip.SetActive(true);
            _tooltipText.text = item.itemToolTip;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null)
        {
            // ������ ������ ���� UI ����
            _tooltip.SetActive(false);
            _tooltipText.text = "";
        }
    }
}
