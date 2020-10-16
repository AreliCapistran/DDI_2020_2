using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;
    public AudioSource Magic;
    public GameObject MagicSleeping;


    public virtual void Interact()
    {
        Instantiate(MagicSleeping);
       // Debug.Log("Pozo: Haz venido a verme... ");
    }

    
    void Update()
    {
        if(isInsideZone)
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }
}
