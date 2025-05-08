using UnityEngine;
using UnityEngine.UI;

public class DisableSelectLevelButton : MonoBehaviour
{
    public int level = 1;
    private Button button;
    private GameObject locker;
    private GameObject play;

    void Awake() {
        button = GetComponent<Button>();
        locker = transform.GetChild(1).gameObject;
        play = transform.GetChild(2).gameObject;

        BloquearFase();
    }

    void BloquearFase() {
        //Fase Liberada
        if (!PlayerPrefs.HasKey("level_"+level) || PlayerPrefs.GetInt("level_"+level) == 0) {
            locker.SetActive(true);
            play.SetActive(false);
            button.interactable = false;
        } 
    }

}
