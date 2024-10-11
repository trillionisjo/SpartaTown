using UnityEngine;
using UnityEngine.UI;

public class NameChangePanel : MonoBehaviour {
    [SerializeField] private Button changeBtn;
    [SerializeField] private Text nameText;

    private void Start () {
        changeBtn.onClick.AddListener(OnChangeBtnClick);
    }

    private void OnChangeBtnClick () {
        PlayerData.GetInstance().ChangePlayerName(nameText.text);
    }

    private void OnEnable () {
        InGameUI.GetInstance()?.CallNameChangePannelOpened(true);
    }

    private void OnDisable () {
        InGameUI.GetInstance()?.CallNameChangePannelOpened(false);
    }
}