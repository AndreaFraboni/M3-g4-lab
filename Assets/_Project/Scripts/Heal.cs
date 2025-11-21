using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<LifeController>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<LifeController>().TakeHeal(healAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("GameObject non riconosciuto !!!");
                return;
            }
        }
        else
        {
            Debug.Log("GameObject non ha il LifeController !!!");
            return;
        }

    }

}
