using System;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    
    private Animator animator;
    private CharacterController controller;

    private float magnitudeThreshold = 0.5f;

    private void Awake () {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void Start () {
        controller.MoveEvent += OnMoveEvent;
    }

    private void OnMoveEvent (Vector2 direction) {
        animator.SetBool(isWalking, direction.magnitude > magnitudeThreshold);
    }
}