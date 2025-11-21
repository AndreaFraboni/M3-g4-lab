using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<LifeController>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<LifeController>().TakeHeal(healAmount);
                Destroy(gameObject);
            }
        }
    }

}
