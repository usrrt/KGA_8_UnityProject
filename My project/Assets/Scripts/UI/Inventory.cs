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
    [SerializeField]
    private PlayerInput _input;

    // 슬롯들 
    public Slot[] slots;

   

    private void Start()
    {
        slots = _slotGrid.GetComponentsInChildren<Slot>(); // 배열안에 슬롯들 넣음
        
    }

    private void Update()
    {
        if(_input.inventoryKey)
        {
            inventoryActivated = !inventoryActivated;
        }
        TryOpenInventory();
    }

    private void TryOpenInventory()
    {
        if(inventoryActivated)
        {
            Cursor.visible = true;
            OpenInventory();
        }
        else
        {
            Cursor.visible = false;
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
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].AddItem(_item, _count);
                return;
            }
        }
    }

    // 슬롯에 사용한 아이템 사용하기
    public void UseItem(string _name)
    {
        int _count = -1;
        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].item != null)
            {
                if (slots[i].item.itemName == _name)
                {
                    slots[i].SetSlotCount(_count);
                }
            }
        }
    }
}
