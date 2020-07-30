using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchDudeInteractions : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        var currentTickets = GameManager.Instance.GetTickets();

        if(currentTickets > 0)
        {
            var sketchGuysGreed = Random.Range(25, 61);
            var moneyFromSketchGuy = Random.Range(2, 11);
            sketchGuysGreed = sketchGuysGreed - currentTickets > 0 ? currentTickets : sketchGuysGreed;

            GameManager.Instance.AddSketchGuysTickets(sketchGuysGreed);
            GameManager.Instance.AddOrSubtractTickets(-sketchGuysGreed);
            GameManager.Instance.AddOrSubtractMoney(moneyFromSketchGuy);
        }
        else
        {
            Debug.Log("Get out of here kid... Come back when you have some tickets...");
        }
    }
}
