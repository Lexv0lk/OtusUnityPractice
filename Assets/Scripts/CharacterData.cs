using UnityEngine;

[CreateAssetMenu(fileName = "Character Data", menuName = "Characters/Data")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;

    public string Name => _name;
    public Sprite Icon => _icon;
}
