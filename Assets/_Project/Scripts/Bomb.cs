using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<LifeController>() != null)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<LifeController>().TakeDamage(damage);
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
            Debug.Log("GameObject non ha il LifeController !!!");
            return;
        }
    }
}
