using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController {
    private Camera mainCamera;

    private void Start () {
        mainCamera = Camera.main;
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
