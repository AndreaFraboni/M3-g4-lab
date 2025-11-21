using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    private int coins;

    public void TakeCoins(int amount)
    {
        coins += amount;
        Debug.Log($"COINS raccolti dal Player : {coins}");
    }
}
