using UnityEngine;

public class DataManager : MonoBehaviour {
    public static DataManager Instance;

    [SerializeField] public StringSO PlayerName;

    private void Awake () {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}
