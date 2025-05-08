using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ChangeLevelButton : MonoBehaviour, ISelectHandler, IPointerEnterHandler {
    
    private SelectLevelController selectLevelController;
    public int level;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
            selectLevelController = FindFirstObjectByType<SelectLevelController>();
    }

    public void OnSelect(BaseEventData eventData)  {
        selectLevelController.HoverLevel(level);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        selectLevelController.HoverLevel(level);
    }
}
