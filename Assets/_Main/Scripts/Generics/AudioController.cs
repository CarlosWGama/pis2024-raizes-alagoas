using System.Linq;
using UnityEngine;

public class AudioController : MonoBehaviour {
    
    private AudioSource BGM;
    private AudioSource BGS;
    private AudioSource SE;

    private static AudioController instance;
    public static AudioController Instance {
        get { return instance; }
    }

    void Awake() {

        //Se já tiver um objeto criado não precisa criar esse novo
        var objects = FindObjectsByType<AudioController>(FindObjectsSortMode.None);
        if (objects.Count() > 1) {
            Destroy(gameObject);
            return;
        }

        BGM = transform.GetChild(0).GetComponent<AudioSource>();
        BGS = transform.GetChild(1).GetComponent<AudioSource>();
        SE = transform.GetChild(2).GetComponent<AudioSource>();

        //Não destroi o objeto entre cenas
        DontDestroyOnLoad(gameObject);
        
        //Padrão Singleton
        instance = this;
    }

    public void PlayBGM(AudioClip audio) {
        BGM.clip = audio;
        BGM.Play();
    }

    public void PlayBGS(AudioClip audio) {
        BGS.clip = audio;
        BGS.Play();
    }

    public void PlaySE(AudioClip audio) {
        SE.PlayOneShot(audio);
    }
}
