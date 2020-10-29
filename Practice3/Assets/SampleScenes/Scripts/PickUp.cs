using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class PickUp : Interactable
{
    private Inventory inventory;
    public Item item;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory==null)
        {
            //Debug.LogWarning("No se encontró en inventario");
        }
    }

    public override void Interact()
    {
        inventory.Add(item);
        Destroy(gameObject);
    }
}
