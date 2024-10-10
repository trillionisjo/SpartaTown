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
        animator.runtimeAnimatorController = DataManager.Instance.SelectedCharacter.CharacterAnimator;
        controller.MoveEvent += OnMoveEvent;
        DataManager.Instance.CharacterChanged += OnCharacterChanged;
    }

    private void OnDestroy () {
        controller.MoveEvent -= OnMoveEvent;
        DataManager.Instance.CharacterChanged -= OnCharacterChanged;
    }

    private void OnMoveEvent (Vector2 direction) {
        animator.SetBool(isWalking, direction.magnitude > magnitudeThreshold);
    }

    private void OnCharacterChanged (CharacterInfo character) {
        animator.runtimeAnimatorController = character.CharacterAnimator;
    }
}