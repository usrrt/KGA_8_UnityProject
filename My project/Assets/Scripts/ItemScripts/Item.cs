using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject // 게임오브젝트에 붙일 필요 x
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
