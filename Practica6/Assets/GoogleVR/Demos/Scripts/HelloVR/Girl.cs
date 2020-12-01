using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Girl : Interactable
{
    public Material[] materials;
    public Renderer myRenderer;

    public override void Interact()
    {
        if (myRenderer != null)
        {
            int index = Random.Range(0, materials.Length);
            myRenderer.material = materials[index];
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Interact();
        }
    }
}
