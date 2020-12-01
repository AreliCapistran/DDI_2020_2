using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
    {
        Pokemon,

        Pokemon1
    }

    [CreateAssetMenu(fileName = "Nuevo Item", menuName = "Inventario/Generic Item")]

    public class Item : ScriptableObject
    {
        public Sprite icon = null;
        public ItemType itemType = ItemType.Pokemon;

        public virtual void Use()
        {
            //Debug.Log("Utilizando");
        }
    }


