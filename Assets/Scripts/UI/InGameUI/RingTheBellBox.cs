using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RingTheBellBox : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI content;
    [SerializeField] private Button callBtn;
    private DialogId id;

    private void Start () {
        callBtn.onClick.AddListener(OnCallBtnClick);
    }

    public void Init(string text, DialogId id) {
        SetText(text);
        this.id = id;
    }

    public void SetText(string text) {
        content.text = text;
    }

    private void OnCallBtnClick () {
        string[] texts = DialogManager.GetInstance().GetDialogTexts(id);
        InGameUI.GetInstance().StartDialog(texts);
        transform.gameObject.SetActive(false);
    }
}