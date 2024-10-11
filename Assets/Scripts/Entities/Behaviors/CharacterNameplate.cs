using TMPro;
using UnityEngine;

public class CharacterNameplate : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI characterName;

    public void SetName (string name) {
        characterName.text = name;
    }

    public string GetName () {
        return characterName.text;
    }
}
