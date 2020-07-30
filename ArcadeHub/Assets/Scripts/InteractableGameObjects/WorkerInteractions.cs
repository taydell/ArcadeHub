using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerInteractions : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        Debug.Log("Interacted with worker");
    }
}
