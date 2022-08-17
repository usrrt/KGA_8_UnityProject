using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject // ���ӿ�����Ʈ�� ���� �ʿ� x
{
    public enum ItemType
    {
        Equipment,
        Used,
        ETC,
    }

    public string ItemName;
    public ItemType itemType;
    public Sprite ItemImg;
    public GameObject ItemPrefab;

}
