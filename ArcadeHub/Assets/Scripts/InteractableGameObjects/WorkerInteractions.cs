using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerInteractions : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        var currentTickets = GameManager.Instance.GetTickets();
        var ticketsRequiredToWin = GameManager.Instance.GetSTicketsRequiredToWin();

        if (currentTickets >= ticketsRequiredToWin)
        {
            Debug.Log("You Win!");
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Not Enough Tickets. You need 2000.");
        }
    }
}
