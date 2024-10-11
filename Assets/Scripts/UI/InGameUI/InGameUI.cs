using System;
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

}
