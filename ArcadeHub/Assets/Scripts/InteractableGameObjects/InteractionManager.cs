using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InteractableGameObjectsEnum;

public class InteractionManager : MonoBehaviour
{
    public void InteractionDecider(GameObject interactableGameObject)
    {
        Debug.Log("");

        var enumScriptOnGameObject = interactableGameObject.GetComponent<InteractableGameObjectsEnum>();

        if (enumScriptOnGameObject)
        {
            switch (enumScriptOnGameObject.WhatEnumAmI)
            {
                case InteractableGameObjectEnum.Worker:
                    interactableGameObject.GetComponent<WorkerInteractions>().Interaction();
                    break;
                case InteractableGameObjectEnum.Machine:
                    interactableGameObject.GetComponent<MachineInteractions>().Interaction();
                    break;
                case InteractableGameObjectEnum.SketchDude:
                    interactableGameObject.GetComponent<SketchDudeInteractions>().Interaction();
                    break;
                case InteractableGameObjectEnum.Exit:
                    interactableGameObject.GetComponent<ExitInteractions>().Interaction();
                    break;
            }
        }
    }
}
