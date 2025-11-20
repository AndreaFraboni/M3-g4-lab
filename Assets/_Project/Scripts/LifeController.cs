using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private void AddHp(int amount)
    {
        health += amount;

        if (health > 0)
        {
            if (health > 100) health = 100;
            Debug.Log($"L'Health attuale del Player è : {health}");
        }
        else if (health <= 0)
        {
            health = 0;
            Debug.Log($"L'Health attuale del Player è : {health}");
            Debug.Log("Il giocatore è stato sconfitto !!!");
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        AddHp(-damage);
    }

    public void TakeHeal(int amount)
    {
        AddHp(amount);
    }

}
