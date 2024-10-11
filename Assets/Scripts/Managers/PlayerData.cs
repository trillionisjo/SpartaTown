using System;
using UnityEngine;
public class PlayerData : MonoBehaviour {
    private static PlayerData instance;

    public static PlayerData GetInstance() {
        return instance;
    }

    public event Action<CharacterInfoSO> PlayerCharacterChanged;
    public event Action<string> PlayerNameChanged;

    private StaticDatas staticDatas;

    [SerializeField] private StringSO playerName;
    [SerializeField] private CharacterInfoSO playerCharacter;

    private void Awake () {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    private void Start () {
        staticDatas = StaticDatas.GetInstance();
    }

    public CharacterInfoSO GetPlayerCharacter () {
        return playerCharacter;
    }

    public void ChangePlayerCharacter (CharacterType type) {
        var charInfo = staticDatas.GetCharacterInfo(type);
        playerCharacter = charInfo;
        PlayerCharacterChanged?.Invoke(charInfo);
    }
    public string GetPlayerName () {
        return playerName.value;
    }

    public void ChangePlayerName (string name) {
        playerName.value = name;
        PlayerNameChanged?.Invoke(name);
    }
}
