using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private Animator _anim;

    private float _movementSpeed = 4.0f;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        HandleMovement();
        HandleAnimations();
    }


    private void HandleMovement()
    {
        float _xInput = Input.GetAxisRaw("Horizontal");
        _rb2D.velocity = new Vector2(_xInput * _movementSpeed, _rb2D.velocity.y);
    }
    private void HandleAnimations()
    {
        _anim.SetFloat("Speed", _rb2D.velocity.x);
    }
}
