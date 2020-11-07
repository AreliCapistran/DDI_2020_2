using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo staff", menuName = "Inventario/Weapon/Staff")]
public class Staff : Item
{
    public int power = 170;
    public int element = 4;

    public override void Use()
    {
        Debug.Log("Tu staff contiene los " + element+ "elementos");
    }
}
