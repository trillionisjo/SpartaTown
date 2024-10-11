using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour {
    [SerializeField] private Text playerNameText;

    public void StartGame () {
        PlayerData.GetInstance().ChangePlayerName(playerNameText.text);
        SceneManager.LoadScene("GameScene");
    }
}
