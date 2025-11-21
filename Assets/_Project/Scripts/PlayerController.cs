using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 5.0f;

    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        if (_rb == null)
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        Move(); // eseguo il movimento in FixedUpdate per gestire il movimento con RigidBody
    }

    void Move()
    {
        // _rb.MovePosition(_rb.position + direction * (_speed * Time.deltaTime));
        _rb.velocity = direction * _speed;
    }

    void CheckInput() // controlla l'Input da tastiera WASD - Tasti freccia .....
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        direction = new Vector2 (h, v); // crea vettore direzione

        //float sqrLenght = direction.sqrMagnitude;
        //if (sqrLenght > 1)
        //{
        //    direction = direction / Mathf.Sqrt(sqrLenght);
        //}
         
        if (direction.sqrMagnitude > 1f)
            direction = direction.normalized;

    }

}
