using UnityEngine;

public enum DialogId { 
    None = 0,
    YeChanTutor = 1,
}


[CreateAssetMenu(fileName = "DialogSO", menuName = "SO/DialogSO")]
public class DialogSO : ScriptableObject {
    public DialogId id;
    public string[] texts;
}
