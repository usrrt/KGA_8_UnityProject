using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // �κ��丮 Ȱ��ȭ�� ���콺�� �����̵� ������
    public static bool inventoryActivated = false;

    [SerializeField]
    private GameObject _inventoryBase;
    [SerializeField]
    private GameObject _slotGrid;
    [SerializeField]
    private PlayerInput _input;

    // ���Ե� 
    public Slot[] slots;

   

    private void Start()
    {
        slots = _slotGrid.GetComponentsInChildren<Slot>(); // �迭�ȿ� ���Ե� ����
        
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

    // ���Կ� ������ ä���ֱ�
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

    // ���Կ� ����� ������ ����ϱ�
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
