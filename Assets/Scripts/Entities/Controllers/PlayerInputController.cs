using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController {
    // Player Input 컴포넌트에서 이동키 입력시 호출되는 함수.
    public void OnIcMove (InputValue value) {
        Vector2 moveDir = value.Get<Vector2>().normalized;
        CallMoveEvent(moveDir);
    }
}
