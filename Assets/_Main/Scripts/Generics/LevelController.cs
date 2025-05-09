using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    
    [Header("Gerenciamento de Fase")]
    public int level = 1;
    public string nextLevel = "_Main/Scenes/Level2/CutScene";

    [Header("Audios")]
    public AudioClip BGM;
    public AudioClip BGS;



    public void CompleteLevel() {
        PlayerPrefs.SetInt("level_"+(level+1), 1);
        SceneManager.LoadScene(nextLevel);
    }

    public void GameOver() {
        PlayerPrefs.SetInt("current_level", level);
        SceneManager.LoadScene("_Main/Scenes/GameOver");
    }

    public void BackMenu() {
        SceneManager.LoadScene("_Main/Scenes/Menu");
    }


    
}
