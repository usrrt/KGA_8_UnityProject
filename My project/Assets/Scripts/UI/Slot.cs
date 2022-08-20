using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public Items item; // ȹ���� ������
    public int itemCount; // ȹ���� ������ ����
    public Image itemImage; // ������ �̹���

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

    // �������̽��� �����⸸ �����
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            // ��Ŭ���� �̺�Ʈ ���� ����
            if(item != null)
            {
                // ����â�� ����
                Debug.Log(item.itemName);
            }
        }
    }
}
