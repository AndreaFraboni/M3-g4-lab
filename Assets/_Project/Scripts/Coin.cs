using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int coinsAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CoinsHandler>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log($"Coins : {coinsAmount}");
                collision.GetComponent<CoinsHandler>().TakeCoins(coinsAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("GameObject non è il Player !!!");
                return;
            }
        }
        else
        {
            Debug.Log("GameObject non ha il CoinsHandler !!!");
            return;
        }
    }

}
