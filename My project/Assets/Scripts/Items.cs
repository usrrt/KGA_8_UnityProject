using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Items : ScriptableObject // ���� ���ӿ�����Ʈ�� ���� �ʿ����
{
    public string itemName; // ������ �̸�
    public Sprite itemImage; // ������ �̹���
    public GameObject itemPrefab; // ������ ������
    public ItemType itemType;

    public enum ItemType
    {
        Equipment,
        Key,
        Memo,
    }

    
}
