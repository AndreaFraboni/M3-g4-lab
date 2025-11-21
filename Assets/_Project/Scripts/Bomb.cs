using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<LifeController>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<LifeController>().TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
