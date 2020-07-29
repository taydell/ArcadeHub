using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableGameObjectsEnum : MonoBehaviour
{
    public enum InteractableGameObjectEnum
    {
        Worker,
        Machine,
        SketchDude,
        Exit
    };

    public InteractableGameObjectEnum WhatEnumAmI;
}
