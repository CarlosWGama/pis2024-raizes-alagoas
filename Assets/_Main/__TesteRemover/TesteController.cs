using UnityEngine;

public class TesteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetLevels() {
        PlayerPrefs.DeleteAll();
        Debug.Log("RESETADO!");
    }
}
