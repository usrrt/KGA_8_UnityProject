using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Items item; // 획득한 아이템
    public int itemCount;
    public Image itemImage;

    // 이미지 투명도 조절
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    // 아이템 획득
    public void AddItem(Items _item, int count = 1)
    {
        item = _item;
        itemCount = count;
        itemImage.sprite = item.itemImage; // item.itemImage 리턴값은 sprite 타입을 준수할것

        SetColor(1);
    }

    // 아이템 개수조절
    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        
        if(itemCount <= 0)
        {
            ClearSlot();
        }
    }

    // 아이템 클리어
    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0);

    }
}
