using System;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    public event Action<Vector2> MoveEvent;

    public void CallMoveEvent (Vector2 direction) {
        MoveEvent?.Invoke(direction);
    }
}
