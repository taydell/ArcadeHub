using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _moneyText, _ticketsText;
    [SerializeField]
    private int _tickets = 0, 
        _sketchGuysTickets = 0,
        _ticketsRequiredToWin;

    private decimal _money = 5.00m;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        _moneyText.SetText(_money.ToString());
        _ticketsText.SetText(_tickets.ToString());
    }

    public void AddOrSubtractMoney(decimal value)
    {
        _money += value;
        _moneyText.SetText(_money.ToString());
    }
    
    public void AddOrSubtractTickets(int value)
    {
        _tickets += value;
        _ticketsText.SetText(_tickets.ToString());
    }

    public void AddSketchGuysTickets(int value)
    {
        _sketchGuysTickets += value;

        if(_sketchGuysTickets >= _ticketsRequiredToWin)
        {
            Time.timeScale = 0;
            Debug.Log("HAHAHAH I HAVE SWINDLED YOU OF THE BEAR!");
            Debug.Log("You Lose");
        }
    }

    public decimal GetMoney()
    {
        return _money;
    }

    public int GetTickets()
    {
        return _tickets;
    }

    public int GetSketchGuysTickets()
    {
        return _sketchGuysTickets;
    }

    public int GetSTicketsRequiredToWin()
    {
        return _ticketsRequiredToWin;
    }
}
