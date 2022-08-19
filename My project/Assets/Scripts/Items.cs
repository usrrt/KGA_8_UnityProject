using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Items : ScriptableObject // 굳이 게임오브젝트에 붙일 필요없음
{
    public string itemName; // 아이템 이름
    public Sprite itemImage; // 아이템 이미지
    public GameObject itemPrefab; // 아이템 프리펩
    public ItemType itemType;

    public enum ItemType
    {
        Equipment,
        Key,
        Memo,
    }

    
}
