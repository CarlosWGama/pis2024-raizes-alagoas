using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {
   
    [Header("Configurações Iniciais")]
    public AudioClip BGM;

    void Start() {
        AudioController.Instance.PlayBGM(BGM);
    }

    public void LoadScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
