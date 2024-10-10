using UnityEngine;
using UnityEngine.UI;

public class PlayerSetup : MonoBehaviour {
    [SerializeField] private Image image;
    [SerializeField] private InputField userName;

    private void Start () {
        DataManager.Instance.CharacterChanged += OnCharacterChanged;
        image.sprite = DataManager.Instance.SelectedCharacter.CharacterImage;
        userName.text = DataManager.Instance.PlayerName.value;
    }

    private void OnDestroy () {
        DataManager.Instance.CharacterChanged -= OnCharacterChanged;
    }

    private void OnCharacterChanged (CharacterInfo character) {
        image.sprite = character.CharacterImage;
    }
}
