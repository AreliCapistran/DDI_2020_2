using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo bow", menuName = "Inventario/Weapon/Bow")]


public class Bow : Item
{
    public int demage = 170;
    public int speed = 4;
    public int arrows = 6;

    public override void Use()
    {
        Debug.Log("Te queda " + arrows + "flechas");
    }
}
