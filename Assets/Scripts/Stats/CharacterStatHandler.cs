using UnityEngine;

public class CharacterStatHandler : MonoBehaviour {
    [SerializeField] private CharacterAbility ability;

    public CharacterAbility GetAbility() {
        return ability;
    }
}
