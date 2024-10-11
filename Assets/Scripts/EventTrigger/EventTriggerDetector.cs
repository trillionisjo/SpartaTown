using UnityEngine;

public class EventTriggerDetector : MonoBehaviour {
    [SerializeField] private LayerMask eventLayer;

    private void OnTriggerEnter2D (Collider2D collision) {
        if (!IsLayerMatched(eventLayer, collision.gameObject.layer)) {
            return;
        }

        var playerObj = collision.gameObject.GetComponent<EventTriggerArea>().GetPlayerObject();
        Debug.Log(playerObj);
    }

    private bool IsLayerMatched (int mask, int target) {
        return mask == (mask | 1 << target);
    }
}