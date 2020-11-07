using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Item", menuName = "Inventario/Weapon/Sword")]

public class Sword : Item
{
    public int demage = 200;
    
    public override void Use()
    {
        Debug.Log("Cada ataque tiene"+demage+"de daño");
    }
}
