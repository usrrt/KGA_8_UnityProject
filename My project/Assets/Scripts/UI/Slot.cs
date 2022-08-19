using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Items item; // ȹ���� ������
    public int itemCount;
    public Image itemImage;

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

    // ������ ��������
    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        
        if(itemCount <= 0)
        {
            ClearSlot();
        }
    }

    // ������ Ŭ����
    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);

    }
}
