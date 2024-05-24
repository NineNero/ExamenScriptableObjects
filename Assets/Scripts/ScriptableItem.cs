using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]

public class ScriptableItem : MonoBehaviour
{
    public enum ItemType
    {
        Weapon,

        Armor,

        Shield
    }

    public ItemType itemType;

    public string itemName;

    public string itemDescription;

    public int itemPrice;

    public Sprite itemSprite;
}
