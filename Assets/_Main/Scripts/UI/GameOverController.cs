using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    public AudioClip BGM;

    void Awake() {
        AudioController.Instance.PlayBGM(BGM);
    }

    public void Repeat() {
        var level = PlayerPrefs.GetInt("current_level");
        SceneManager.LoadScene("_Main/Scenes/Level"+level+"/Level");
    }

    public void Home() {
        SceneManager.LoadScene("_Main/Scenes/Menu");
    }
}
