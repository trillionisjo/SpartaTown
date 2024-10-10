using UnityEngine;

public class CharacterStatHandler : MonoBehaviour {
    [SerializeField] CharacterStat baseStat;
    public CharacterStat CurrentStat { get; set; }

    private void Awake () {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat () {
        CurrentStat = new CharacterStat();
        CurrentStat.moveSpeed = baseStat.moveSpeed;
    }

}
