using UnityEngine;

public enum DialogId { 
    None = 0,
    YeChanTutor = 1,
    Penguin = 2,
    JiWonTutor = 3,
    AlarmElf = 4,
    JungHoTutor = 5,
}


[CreateAssetMenu(fileName = "DialogSO", menuName = "SO/DialogSO")]
public class DialogSO : ScriptableObject {
    public DialogId id;
    public string[] texts;
}
