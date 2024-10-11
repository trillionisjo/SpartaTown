using System;
using UnityEngine;

[RequireComponent(typeof(CharacterAnimation))]
[RequireComponent(typeof(CharacterNameplate))]
public class PlayerUpdater : MonoBehaviour {
    private CharacterAnimation anim;
    private CharacterNameplate nameplate;
    private PlayerData playerData;

    private void Awake () {
        anim = GetComponent<CharacterAnimation>();
        nameplate = GetComponent<CharacterNameplate>();
    }

    private void Start () {
        playerData = PlayerData.GetInstance();

        nameplate.SetName(playerData.GetPlayerName());
        anim.SetRac(playerData.GetPlayerCharacter().rac);

        playerData.PlayerCharacterChanged += OnCharacterChanged;
        playerData.PlayerNameChanged += OnPlayerNameChanged;
    }

    private void OnDestroy () {
        playerData.PlayerCharacterChanged -= OnCharacterChanged;
        playerData.PlayerNameChanged -= OnPlayerNameChanged;
    }

    private void OnCharacterChanged (CharacterInfoSO character) {
        anim.SetRac(character.rac);
    }

    private void OnPlayerNameChanged (string name) {
        nameplate.SetName(name);
    }
}
