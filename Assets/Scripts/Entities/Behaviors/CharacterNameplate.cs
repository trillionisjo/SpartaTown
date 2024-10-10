using TMPro;
using UnityEngine;

public class CharacterNameplate : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI characterName;

    private void Start () {
        UpdateName();
    }

    private void UpdateName () {
        characterName.text = DataManager.Instance.PlayerName.value;
    }
}
