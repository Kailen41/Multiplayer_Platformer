using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb2D;

    private float _movementSpeed = 8.0f;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        float _xInput = Input.GetAxisRaw("Horizontal");
        _rb2D.velocity = new Vector2(_xInput * _movementSpeed, _rb2D.velocity.y);
    }
}
