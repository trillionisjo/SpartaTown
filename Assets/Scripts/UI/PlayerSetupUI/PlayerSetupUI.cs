using UnityEngine;
using UnityEngine.UI;

public class PlayerSetupUI : MonoBehaviour {
    [SerializeField] private Image image;
    [SerializeField] private InputField userName;
    private PlayerData playerData;

    private void Start () {
        playerData = PlayerData.GetInstance();
        playerData.PlayerCharacterChanged += OnCharacterChanged;
        image.sprite = playerData.GetPlayerCharacter().sprite;
        userName.text = playerData.GetPlayerName();
    }

    private void OnDestroy () {
        playerData.PlayerCharacterChanged -= OnCharacterChanged;
    }

    private void OnCharacterChanged (CharacterInfoSO character) {
        image.sprite = character.sprite;
    }
}
