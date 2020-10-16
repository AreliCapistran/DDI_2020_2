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
        //Debug.Log("Pozo: Haz venido a verme... ");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
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
        //Debug.Log("Traspaso el lago: " + other.gameObject.name);
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
