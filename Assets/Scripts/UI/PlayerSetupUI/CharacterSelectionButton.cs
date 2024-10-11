using UnityEngine;

public class CharacterSelectionButton : MonoBehaviour
{
    private PlayerData playerData;

    private void Start () {
        playerData = PlayerData.GetInstance();
    }

    public void SelectKnight () {
        playerData.ChangePlayerCharacter(CharacterType.Knight);
    }

    public void SelectWizzard () {
        playerData.ChangePlayerCharacter(CharacterType.Wizzard);
    }

    public void SelectLizard () {
        playerData.ChangePlayerCharacter(CharacterType.Lizard);
    }
}
