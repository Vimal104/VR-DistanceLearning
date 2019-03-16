using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GrabWithPointer : MonoBehaviour
{
    VRTK_InteractableObject interact;
    // Start is called before the first frame update
    void Start()
    {
        interact = GetComponent<VRTK_InteractableObject>();

        interact.InteractableObjectUsed += Interact_InteractableObjectUsed;
    }

    private void Interact_InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
