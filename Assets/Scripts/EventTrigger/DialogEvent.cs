using System;
using TMPro;
using UnityEngine;

public class DialogEvent : EventTrigger {
    [SerializeField] private TextMeshProUGUI nameTagText;
    [SerializeField] private DialogId id;

    public override void StartEvent () {
        string name = nameTagText.text;
        InGameUI.GetInstance().ShowRingTheBellBox(name, id);
    }

    public override void ExitEvent () {
        InGameUI.GetInstance().HideRingTheBellBox();
    }
}
