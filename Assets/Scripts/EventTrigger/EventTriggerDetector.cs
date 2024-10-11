using UnityEngine;

public class EventTriggerDetector : MonoBehaviour {
    [SerializeField] private LayerMask eventLayer;

    private void OnTriggerEnter2D (Collider2D collision) {
        if (!IsLayerMatched(eventLayer, collision.gameObject.layer)) {
            return;
        }

        var trigger = collision.gameObject.GetComponent<EventTrigger>();
        trigger.StartEvent();
    }

    private void OnTriggerExit2D (Collider2D collision) {
        if (!IsLayerMatched(eventLayer, collision.gameObject.layer)) {
            return;
        }

        var trigger = collision.gameObject.GetComponent<EventTrigger>();
        trigger.ExitEvent();
    }

    private bool IsLayerMatched (int mask, int target) {
        return mask == (mask | 1 << target);
    }
}