using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {
    private static DialogManager instance;

    public static DialogManager GetInstance () {
        return instance;
    }

    [SerializeField] private List<DialogSO> dialogSOList;
    private Dictionary<DialogId, DialogSO> dialogSODic;

    private void Awake () {
        instance = this;

        dialogSODic = new Dictionary<DialogId, DialogSO>();
        foreach (DialogSO dialog in dialogSOList) {
            dialogSODic.Add(dialog.id, dialog);
        }
    }

    public string[] GetDialogTexts (DialogId id) {
        return dialogSODic[id].texts;
    }
}