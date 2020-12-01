using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARinteraction : MonoBehaviour
{
    private Inventory inventory;
    public Item item;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        inventory = FindObjectOfType<Inventory>();
        inventory.Add(item);
        Destroy(gameObject);
    }
}
