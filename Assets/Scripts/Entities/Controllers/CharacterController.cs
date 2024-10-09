using System;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    public event Action<Vector2> MoveEvent;
    public event Action<Vector2> LookEvent;

    public void CallMoveEvent (Vector2 direction) {
        MoveEvent?.Invoke(direction);
    }

    public void CallLookEvent (Vector2 direction) {
        LookEvent?.Invoke(direction);
    }
}
