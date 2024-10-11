using UnityEngine;

public class EventTriggerArea : MonoBehaviour {
    [SerializeField] private GameObject playerObject;

    public GameObject GetPlayerObject () {
        return playerObject;
    }
}