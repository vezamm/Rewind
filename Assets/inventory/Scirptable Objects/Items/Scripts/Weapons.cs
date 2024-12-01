using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]

public class Weapons : ItemObject
{
    public void Awake()
    {
        type = ItemType.weapons;
    }
}
