using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Items item; // 획득한 아이템
    public int itemCount; // 획득한 아이템 갯수
    public Image itemImage; // 아이템 이미지

    [SerializeField]
    private GameObject _tooltip;

    [SerializeField]
    private TextMeshProUGUI _tooltipText;

    private void Awake()
    {
        _tooltip.SetActive(false);
    }

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

    // 슬롯개수 조절
    public void SetSlotCount(int _count)
    {
        itemCount += _count;

        if (itemCount <= 0)
        {
            clearslot();
        }
    }

    // 아이템 클리어
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
            // 아이템 각각의 툴팁 UI 켜기
            _tooltip.SetActive(true);
            _tooltipText.text = item.itemToolTip;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null)
        {
            // 아이템 각각의 툴팁 UI 끄기
            _tooltip.SetActive(false);
            _tooltipText.text = "";
        }
    }
}
