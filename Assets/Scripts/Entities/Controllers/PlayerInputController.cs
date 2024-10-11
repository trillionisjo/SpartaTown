using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController {
    private Camera mainCamera;
    private PlayerInput playerInput;
    private InputActionMap inputActionsMap;

    private void Awake () {
        playerInput = GetComponent<PlayerInput>();
        inputActionsMap = playerInput.currentActionMap;
        //inputActionsMap = inputActionsAsset.FindActionMap("Player");
    }

    private void Start () {
        mainCamera = Camera.main;
        InGameUI.GetInstance().NameChangePannelOpened += OnNameChangePannelOpened;
    }

    private void OnDestroy () {
        InGameUI.GetInstance().NameChangePannelOpened -= OnNameChangePannelOpened;
    }

    private void OnNameChangePannelOpened (bool active) {
        if (active) {
            inputActionsMap.Disable();
        } else {
            inputActionsMap.Enable();
        }
    }

    public void OnIcMove (InputValue value) {
        Vector2 moveDir = value.Get<Vector2>().normalized;
        CallMoveEvent(moveDir);
    }

    public void OnIcLook (InputValue value) {
        Vector2 mousePos = value.Get<Vector2>();
        mousePos = mainCamera.ScreenToWorldPoint(mousePos);
        Vector2 lookDir = (mousePos - (Vector2)transform.position).normalized;
        CallLookEvent(lookDir);
    }
}
