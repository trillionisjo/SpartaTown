using UnityEngine;

public enum CharacterType {
    Knight = 1,
    Wizzard = 2,
    Lizard = 3,
}

[CreateAssetMenu(fileName = "CharacterInfoSO", menuName = "SO/CharacterInfo")]
public class CharacterInfo : ScriptableObject {
    public CharacterType CharacterType;
    public Sprite CharacterImage;
    public RuntimeAnimatorController CharacterAnimator;
}
