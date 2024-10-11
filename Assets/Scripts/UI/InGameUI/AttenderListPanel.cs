using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class AttenderListPanel : MonoBehaviour {
    [SerializeField] private Text attenderListText;
    private PlayerData playerData;

    private void Start () {
        playerData = PlayerData.GetInstance();
        playerData.PlayerNameChanged += OnPlayerNameChanged;
        UpdateAttenderList();
    }

    private void OnDestroy () {
        playerData.PlayerNameChanged -= OnPlayerNameChanged;
    }

    private void OnPlayerNameChanged (string name) {
        UpdateAttenderList();
    }

    private void UpdateAttenderList () {
        List<string> list = PlayerObjecsList.GetInstance().GetNameList();
        var sb = new StringBuilder();

        foreach (var name in list) {
            sb.Append($"{name}\n");
        }

        attenderListText.text = sb.ToString();
    }
}