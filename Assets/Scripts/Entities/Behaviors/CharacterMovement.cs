using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour {
    private Rigidbody2D rigidbody2d;
    private Collider2D collider2d;
    private CharacterController controller;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake () {
        rigidbody2d = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        controller = GetComponent<CharacterController>();
    }

    private void Start () {
        controller.MoveEvent += OnMoveEvent;
    }

    private void FixedUpdate () {
        rigidbody2d.velocity = movementDirection;
    }

    private void OnMoveEvent (Vector2 direction) {
        movementDirection = direction * 5f;
    }
}