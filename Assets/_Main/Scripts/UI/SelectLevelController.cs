using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SelectLevelController : MonoBehaviour {
    

    [Header("UI")]
    public TMP_Text levelTitle;
    public Image background;

    [Header("Level 1")]
    public GameObject ButtonLevel1;
    public Sprite backgroundLevel1;
    public string title1Name = "Mundo 1 - Criação da Província de Alagoas";
    public string level1Name = "_Main/Scenes/Level1/CutScene";
    
    [Header("Level 2")]
    public GameObject ButtonLevel2;
    public Sprite backgroundLevel2;
    public string title2Name = "Mundo 2 - Guerra dos Cabanos";
    public string level2Name = "_Main/Scenes/Level2/CutScene";

    [Header("Level 3")]
    public GameObject ButtonLevel3;
    public Sprite backgroundLevel3;
    public string title3Name = "Mundo 3 - A Proclamação da República";
    public string level3Name = "_Main/Scenes/Level3/CutScene";

    [Header("Level 4")]
    public GameObject ButtonLevel4;
    public Sprite backgroundLevel4;
    public string title4Name = "Mundo 4 - Cangaço";
    public string level4Name = "_Main/Scenes/Level4/CutScene";

    public void HoverLevel(int level) {
        switch(level) {
            case 1: 
                levelTitle.text = title1Name;
                background.sprite = backgroundLevel1;
                break;
            case 2:
                levelTitle.text = title2Name;
                background.sprite = backgroundLevel2;
                break;
            case 3:
                levelTitle.text = title3Name;
                background.sprite = backgroundLevel3;
                break;
            case 4:
                levelTitle.text = title4Name;
                background.sprite = backgroundLevel4;
                break;
        }
    }

    public void SelectLevel(int level) {
        switch(level) {
            case 1: SceneManager.LoadScene(level1Name); break;
            case 2: SceneManager.LoadScene(level2Name); break;
            case 3: SceneManager.LoadScene(level3Name); break;
            case 4: SceneManager.LoadScene(level4Name); break;
                
        }
    }

    public void GoHome() {
        SceneManager.LoadScene("_Main/Scenes/Menu");
    }
}
