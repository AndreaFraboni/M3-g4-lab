using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int coinsAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<LifeController>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log($"Coins : {coinsAmount}");
                collision.GetComponent<CoinsHandler>().TakeCoins(coinsAmount);
                Destroy(gameObject);
            }
        }
    }

}
