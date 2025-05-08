using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
public class CutsceneController : MonoBehaviour
{

    private Image background;
    private TMP_Text text;
    private Animator animator;

    // -------------------------------
    public CutSceneObject[] itens;
    public AudioClip audio;
    public string nextScene = "_Main/Scenes/Menu";
    // -------------------------------
    private float timerController;
    private int currentIndex = -1;
    private bool lastItem = false;

    void Awake() {
        background = transform.GetChild(0).GetComponent<Image>();
        text = transform.GetChild(1).GetComponent<TMP_Text>();
        animator = GetComponent<Animator>();
        
        //Tem item?
        if (itens.Count() > 0)  GetNext();
        else                    Finish();
    }

    void Start () {
        if (audio) AudioController.Instance.PlayBGM(audio);
    }

    void Update() {
        timerController -= Time.deltaTime;

        
        //Troca de Cutscene
        if (timerController < 0) {
            //Aplica o Efeito de Fade Out
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("FadeOut")) {
                //Aplicação animação FadeOut
                animator.SetTrigger("FadeOut");
            } else {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f) {
                    // A animação FadeOut terminou
                    if (!lastItem)  GetNext();
                    else            Finish();
                }
            }
        }
        
    }

    /// <summary> Busca próximo item da cutscene </summary>
    private void GetNext() {
        currentIndex++;

        background.sprite = itens[currentIndex].background;
        text.text = itens[currentIndex].text;
        timerController = itens[currentIndex].timer;

        lastItem = currentIndex == (itens.Count() - 1);
        animator.SetTrigger("FadeIn");
        
    }

    /// <summary> Encerra os créditos </summary>
    private void Finish() {
        SceneManager.LoadScene(nextScene);
    }
}
