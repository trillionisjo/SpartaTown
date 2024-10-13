using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour {
    private static InGameUI instance;

    public static InGameUI GetInstance() {
        return instance;
    }

    public event Action<bool> NameChangePannelOpened;

    [SerializeField] private GameObject nameChangePanel;
    [SerializeField] private GameObject charChangePanel;
    [SerializeField] private GameObject attenderListPanel;
    [SerializeField] private GameObject ringTheBellBox;
    [SerializeField] private DialogBox dialogBox;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private Button nameChangeBtn;
    [SerializeField] private Button charChangeBtn;
    [SerializeField] private Button attenderListBtn;

    private void Awake () {
        instance = this;
    }

    private void Start () {
        nameChangeBtn.onClick.AddListener(OnNameChangeBtnClick);
        charChangeBtn.onClick.AddListener(OnCharChangeBtnClick);
        attenderListBtn.onClick.AddListener(OnAttenderListBtnClick);
    }

    private void Update () {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    private void OnNameChangeBtnClick () {
        nameChangePanel.SetActive(!nameChangePanel.activeSelf);
        charChangePanel.SetActive(false);
    }

    private void OnCharChangeBtnClick () {
        charChangePanel.SetActive(!charChangePanel.activeSelf);
        nameChangePanel.SetActive(false);
    }

    private void OnAttenderListBtnClick () {
        attenderListPanel.SetActive(!attenderListPanel.activeSelf);
    }

    public void CallNameChangePannelOpened(bool active) {
        NameChangePannelOpened?.Invoke(active);
    }

    public void ShowRingTheBellBox (string contentText, DialogId id) {
        var box = ringTheBellBox.GetComponent<RingTheBellBox>();
        box.Init(contentText, id);
        ringTheBellBox?.SetActive(true);
    }

    public void HideRingTheBellBox () {
        if (ringTheBellBox == true) {
            ringTheBellBox.SetActive(false);
        }
    }

    public void StartDialog (string[] texts) {
        dialogBox.StartDialog(texts);
    }

    public void EndDialog () {
        if (dialogBox == true) {
            dialogBox.gameObject.SetActive(false);
        }
    }
}
