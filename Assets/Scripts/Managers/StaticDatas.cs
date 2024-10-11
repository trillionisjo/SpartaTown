using System;
using System.Collections.Generic;
using UnityEngine;

public class StaticDatas : MonoBehaviour {
    private static StaticDatas instance;

    public static StaticDatas GetInstance() {
        return instance;
    }

    private Dictionary<CharacterType, CharacterInfoSO> characterInfoDic;
    [SerializeField] private List<CharacterInfoSO> characterInfoList;

    private void Awake () {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        instance = this;

        characterInfoDic = new Dictionary<CharacterType, CharacterInfoSO>();
        foreach (CharacterInfoSO charInfo in characterInfoList) {
            characterInfoDic.Add(charInfo.type, charInfo);
        }
    }

    public CharacterInfoSO GetCharacterInfo (CharacterType type) {
        return characterInfoDic[type];
    }
}
