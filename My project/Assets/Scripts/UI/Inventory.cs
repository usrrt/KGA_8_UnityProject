using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // 인벤토리 활성화시 마우스로 시점이동 방지용
    public static bool inventoryActivated = false;

    [SerializeField]
    private GameObject _inventoryBase;
    [SerializeField]
    private GameObject _slotGrid;

    private Slot[] slots; // 슬롯들을 배열로 가져온다

    private bool openIventory;

    private void Start()
    {
        slots = _slotGrid.GetComponentsInChildren<Slot>(); // 배열안에 슬로들 넣음
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            openIventory = !openIventory;
        }
        TryOpenInventory();
    }

    private void TryOpenInventory()
    {
        if(openIventory)
        {
            OpenInventory();
        }
        else
        {
            CloseInventory();
        }
    }

    private void CloseInventory()
    {
        _inventoryBase.SetActive(false);
    }

    private void OpenInventory()
    {
        _inventoryBase.SetActive(true);
    }

    // 슬롯에 아이템 채워넣기
    public void AcquireItem(Items _item, int _count = 1)
    {
        // 장비아이템이 아닌경우(재료인경우) 카운트만 증가시킨다.
        if(Items.ItemType.Equipment != _item.itemType)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName)
                    {
                        slots[i].SetSlotCount(_count);
                        return;
                    }
                }
            }
        }

        for (int i = 0; i < slots.Length; i++)
        {

            if (slots[i].item == null)
            {
                slots[i].AddItem(_item, _count);
            }

        }
    }
}
