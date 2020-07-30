using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineInteractions : MonoBehaviour, IInteraction
{
    public decimal _costToPlay = 1.00m;

    public void Interaction()
    {
        var currentMoney = GameManager.Instance.GetMoney();

        if (currentMoney - _costToPlay >= 0)
        {
            GameManager.Instance.AddOrSubtractMoney(-_costToPlay);
            GameManager.Instance.AddOrSubtractTickets(Random.Range(1, 76));
        }
    }
}
