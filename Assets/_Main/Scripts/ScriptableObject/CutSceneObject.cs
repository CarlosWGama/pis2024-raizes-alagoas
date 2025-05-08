using UnityEngine;

[CreateAssetMenu(fileName = "CutScene", menuName = "Scriptable Objects/CutScene")]
public class CutSceneObject : ScriptableObject
{
    public Sprite background;
    [TextArea(10, 100)]
    public string text;
    public float timer = 3f;

}
