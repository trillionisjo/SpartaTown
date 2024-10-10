using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour {
    [SerializeField] private Text playerNameText;

    public void Enter () {
        DataManager.Instance.PlayerName.value = playerNameText.text;
        SceneManager.LoadScene("GameScene");
    }
}
