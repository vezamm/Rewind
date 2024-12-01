using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemObject;

[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory System/Items/Food")]

public class FoodObjects : ItemObject
{
    public void Awake()
    {
        type = ItemType.Food;
    }
}
