using UnityEngine;

public class CharacterSelectionButton : MonoBehaviour
{
    public void SelectKnight () {
        DataManager.Instance.ChangeCharacter(CharacterType.Knight);
    }

    public void SelectWizzard () {
        DataManager.Instance.ChangeCharacter(CharacterType.Wizzard);
    }

    public void SelectLizard () {
        DataManager.Instance.ChangeCharacter(CharacterType.Lizard);
    }
}
