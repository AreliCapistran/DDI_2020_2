using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : VoiceInteractable
{
    public Material[] materials;
    public Renderer myRenderer;

    public override void VoiceInteract(string action)
    {
        Debug.Log("Ropa nueva!");
        if (action == "change")
        {
            int index = Random.Range(0, materials.Length);
            myRenderer.material = materials[index];
        }
    }
}
