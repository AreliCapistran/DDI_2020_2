using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public enum ItemType
{
    Weapon,

    Equip,

    Medicine
}

[CreateAssetMenu(fileName = "Nuevo Item", menuName = "Inventario/Generic Item")]

public class Item : ScriptableObject
{
    public Sprite icon = null;
    public ItemType itemType = ItemType.Weapon;

    public virtual void Use()
    {
        //Debug.Log("Utilizando");
    }
}
