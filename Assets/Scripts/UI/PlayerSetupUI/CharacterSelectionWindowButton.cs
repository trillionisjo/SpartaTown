using UnityEngine;

public class CharacterSelectionWindowButton : MonoBehaviour
{
    [SerializeField] GameObject CharacterSelectionWindow;

    public void Open () {
        CharacterSelectionWindow.SetActive(true);
    }

    public void Close () {
        CharacterSelectionWindow.SetActive(false);
    }
}
