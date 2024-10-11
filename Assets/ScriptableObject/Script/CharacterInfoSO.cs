using UnityEngine;

public enum CharacterType {
    Knight = 1,
    Wizzard = 2,
    Lizard = 3,
}

[CreateAssetMenu(fileName = "CharacterInfoSO", menuName = "SO/CharacterInfo")]
public class CharacterInfoSO : ScriptableObject {
    public CharacterType type;
    public Sprite sprite;
    public RuntimeAnimatorController rac;
}
