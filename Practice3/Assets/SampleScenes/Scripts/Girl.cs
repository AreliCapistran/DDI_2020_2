using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : Interactable
{

    Rigidbody rb;
    bool interactionSet = false;
    public float torque;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (interactionSet)
        {
            rb.AddTorque(transform.up * torque * -1f);
        }

    }

    public override void Interact()
    {
        base.Interact();
        interactionSet = true;
    }
}
