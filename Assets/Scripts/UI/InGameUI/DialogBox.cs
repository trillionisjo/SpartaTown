using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour {
    [SerializeField] private Button nextBtn;
    [SerializeField] private Button endBtn;
    [SerializeField] private TextMeshProUGUI tmp;

    private string[] texts;
    private int textIdx;

    private void Awake () {
        nextBtn.onClick.AddListener(OnNextBtnClick);
        endBtn.onClick.AddListener(OnEndBtnClick);
    }

    private void OnEndBtnClick () {
        transform.gameObject.SetActive(false);
    }

    private void OnNextBtnClick () {
        tmp.text = texts[textIdx++];
        nextBtn.gameObject.SetActive(texts.Length > textIdx);
    }

    public void StartDialog(string[] texts) {
        this.texts = texts;
        textIdx = 0;

        tmp.text = texts[textIdx++];
        nextBtn.gameObject.SetActive(texts.Length > textIdx);
        transform.gameObject.SetActive(true);
    }
}