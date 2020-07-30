using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineInteractions : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        Debug.Log("Interacted with Machine");
    }
}
