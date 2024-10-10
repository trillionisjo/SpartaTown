using System;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
    public static DataManager Instance;

    public event Action<CharacterInfo> CharacterChanged;

    public Dictionary<CharacterType, CharacterInfo> CharacterInfoDic;
    [SerializeField] private List<CharacterInfo> CharacterInfoList;

    public StringSO PlayerName;
    public CharacterInfo SelectedCharacter;

    private void Awake () {
        CharacterInfoDic = new Dictionary<CharacterType, CharacterInfo>();

        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start () {
        foreach (CharacterInfo info in CharacterInfoList) {
            CharacterInfoDic.Add(info.CharacterType, info);
        }
    }

    public void ChangeCharacter (CharacterType type) {
        CharacterChanged?.Invoke(CharacterInfoDic[type]);
        SelectedCharacter = CharacterInfoDic[type];
    }
}
