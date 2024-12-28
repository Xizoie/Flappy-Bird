using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private GameObject _bird;

    [SerializeField] private float _jumpHeight;
    [SerializeField] private float _rotationSpeed;


    

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            Jump();


    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0, _rb.linearVelocity.y * _rotationSpeed);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocityX, _jumpHeight);
            AudioManager.instance.Flip();

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.Death();
        GameManager.instance.GameOver();
        
    }
}
