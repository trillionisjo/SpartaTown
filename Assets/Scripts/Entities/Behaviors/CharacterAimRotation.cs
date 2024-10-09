using System;
using UnityEngine;

public class CharacterAimRotation : MonoBehaviour {
    [SerializeField] private SpriteRenderer characterRenderer;

    private CharacterController controller;

    private void Awake () {
        controller = GetComponent<CharacterController>();
    }

    private void Start () {
        controller.LookEvent += OnLookEvent;
    }

    private void OnLookEvent (Vector2 direction) {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
