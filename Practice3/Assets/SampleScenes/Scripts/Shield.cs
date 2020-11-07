using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Shield", menuName = "Inventario/Weapon/Shield")]

public class Shield : Item
{

    public int demage = 10;
    public int durability = 600;

    public override void Use()
    {
        Debug.Log("Cada ataque tiene un aguante de" + durability);
    }
}
