using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;

public class PickUp : VoiceInteractable
{
    /* private Inventory inventory;
     public Item item;*/

    public GameObject other;
    public Text dtext, found;
    public int cont = 0;

    void Start()
    {
        /*inventory = FindObjectOfType<Inventory>();
        if(inventory==null)
        {
            //Debug.LogWarning("No se encontró en inventario");
        }*/
    }

    public override void VoiceInteract(string action)
    {
        
        if (other.gameObject.CompareTag("Laptop"))
        {
            cont = cont + 1;
            Destroy(other);
            dtext.text = "Laptop: 1";
        }
        else if (other.gameObject.CompareTag("Knife"))
        {
            cont = cont + 1;
            Destroy(other);
            dtext.text = "Knife: 1";
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            cont = cont + 1;
            Destroy(other);
            dtext.text = "Key: 1";
        }
        else if (other.gameObject.CompareTag("Axe"))
        {
            cont = cont + 1;
            Destroy(other);
            dtext.text = "Axe: 1";
        }
        else if (other.gameObject.CompareTag("Sha"))
        {
            cont = cont + 1;
            Destroy(other);
            dtext.text = "Shackles: 1";
        }

        if (cont == 5)
        {
            found.text = "Encontrados";
            Application.Quit();
        }
    }
}

